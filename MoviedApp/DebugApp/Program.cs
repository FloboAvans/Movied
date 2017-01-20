using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HashingTest;
using Newtonsoft.Json.Linq;
using Shared_Code;
using Shared_Code_Portable;
using Shared_Code_Portable.ClientSide;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerHandler.instance.OnHandshakeComplete += LoginHandler;
            while (true)
            {
                Thread.Sleep(10000000);
            }
            
        }

        #region login

        private static void LoginHandler()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            UniqeRandomNumber.makeRandom = i =>
            {
                byte[] bytes = new byte[i];
                rng.GetBytes(bytes);
                return bytes;
            };

            string debug;
            do
            {
                Console.Write("debug mode?['y' or 'n']: ");
                debug = Console.ReadLine();
            } while (debug != "y" && debug != "n");
            if (debug == "y")
            {
                Action<Message> OnMessage = ServerConnector.instance.OnMessageRecieved;
                ServerConnector.instance.OnMessageRecieved =
                    message => Console.WriteLine("message recieved:\r\n\t" + message);
                ServerConnector.instance.OnMessageRecieved += OnMessage;
            }
            string mode;
            do
            {
                Console.WriteLine("\"login\" or \"create\"");
                mode = Console.ReadLine();
            } while (mode != "login" && mode != "create");
            if (mode == "login") Login();
            else Create();
        }

        private static void Login()
        {
                Console.Write("username: ");
                string username = Console.ReadLine();

                ServerHandler.instance.SendMessage(new Message
                {
                    destinationID = ServerHandler.instance.serverNodeID,
                    senderID = ServerHandler.instance.clientID,
                    traceNumber = TraceID.GenerateTraceID(),
                    type = Message.Type.ClientServer.Login.saltRequest,
                    isResponse = false,
                    message = new {username = username},
                    succes = true
                }, message =>
                {
                    if (message.succes == false)
                    {
                        Console.WriteLine("username does not exist");
                        Login();
                    }
                    else
                    {
                        byte[] saltBytes = Convert.FromBase64String((string) message.message.salt);
                        LoginPassword((int)message.message.userid, saltBytes, message.traceNumber);
                    }
                });
        }

        private static int _userid = -1;

        private static void LoginPassword(int userid, byte[] salt, TraceID traceID)
        {
            Console.Write("password: ");
            string password = Console.ReadLine();

            ServerHandler.instance.SendMessage(new Message
            {
                destinationID = ServerHandler.instance.serverNodeID,
                senderID = ServerHandler.instance.clientID,
                traceNumber = traceID,
                isResponse = false,
                succes = true,
                type = Message.Type.ClientServer.Login.checkHash,
                message = new
                {
                    hash = Convert.ToBase64String(PasswordBank.HashPasword(password, salt)),
                    userid = userid
                }
            }, message =>
            {
                if ((PasswordBank.Response)message.message.response == PasswordBank.Response.SUCCES )
                {
                    _userid = userid;
                    Console.WriteLine("login succesfull");
                    MainPage();
                }
                else
                {
                    LoginPassword((int)message.message.userid, salt, traceID);
                }
            });
        }

        private static void Create()
        {
            Console.Write("username: ");
            string username = Console.ReadLine();

            ServerHandler.instance.SendMessage(new Message
            {
                destinationID = ServerHandler.instance.serverNodeID,
                senderID = ServerHandler.instance.clientID,
                isResponse = false,
                succes = true,
                traceNumber = TraceID.GenerateTraceID(),
                type = Message.Type.ClientServer.Login.createUser,
                message = new {username = username}
            }, message =>
            {
                if (message.succes == false)
                {
                    Console.WriteLine("username is not avalible");
                    Create();
                }
                else
                {
                    byte[] saltBytes = Convert.FromBase64String((string)message.message.salt);
                    CreatePassword((int)message.message.userid, saltBytes, message.traceNumber);
                }
            });
        }

        private static void CreatePassword(int userid, byte[] salt, TraceID traceID)
        {
            Console.Write("password: ");
            string password = Console.ReadLine();

            ServerHandler.instance.SendMessage(new Message
            {
                destinationID = ServerHandler.instance.serverNodeID,
                senderID = ServerHandler.instance.clientID,
                traceNumber = traceID,
                isResponse = false,
                succes = true,
                type = Message.Type.ClientServer.Login.setHash,
                message = new
                {
                    hash = Convert.ToBase64String(PasswordBank.HashPasword(password, salt)),
                    userid = userid
                }
            }, message =>
            {
                _userid = userid;
                Console.WriteLine("account created succesfully");
                MainPage();
            });
        }

        #endregion
        private static void MainPage()
        {
            string mode = null;
            do
            {
                Console.Write("checkin new, mod, get: ");
                mode = Console.ReadLine()?.Trim();
            } while (mode != "new" && mode != "get" && mode != "mod");
            if (mode == "new") NewCheckin();
            else if (mode == "mod") ModCheckin();
            else if (mode == "get") GetCheckins();
        }

        private static void GetCheckins()
        {
            ServerHandler.instance.SendMessage(new Message
            {
                traceNumber = TraceID.GenerateTraceID(),
                type = Message.Type.UserData.CheckIn.getAll,
                succes = true,
                isResponse = false,
                message = new
                {
                    userid = _userid
                }
            }, message =>
            {
                if (message.succes && message.message != null && (checkIns = ((JObject)message.message).DeserializeToCheckIns()).Count > 0)
                {
                    foreach (CheckIn checkIn in checkIns)
                    {
                        Console.WriteLine("\t"+checkIn);
                    }
                }
                else
                {
                    Console.WriteLine("\tempty list");
                }
                MainPage();
            });
        }

        private static void NewCheckin()
        {
            int movieId = -1;
            do
            {
                Console.Write("\tmovieId(> 0): ");
                int.TryParse(Console.ReadLine().Trim(), out movieId);
            } while (movieId < 0);

            int rating = -1;
            do
            {
                Console.Write("\trating(0-10)[- for na): ");
                string input = Console.ReadLine().Trim();
                if (input == "-")
                {
                    rating = int.MinValue;
                    break;
                }
                int.TryParse(input, out rating);
            } while (rating < 0 || rating > 10);

            Console.Write("\tdescription: ");
            string description = Console.ReadLine().Trim();

            CheckIn checkIn = new CheckIn(null);
            checkIn.movieId = movieId;
            if (rating != int.MinValue) checkIn.rating = (byte) rating;
            if (description != "") checkIn.description = description;

            ServerHandler.instance.SendMessage(new Message
            {
                traceNumber = TraceID.GenerateTraceID(),
                type = Message.Type.UserData.CheckIn.create,
                isResponse = false,
                succes = true,
                message = new
                {
                    userid = _userid,
                    checkIn
                }
            }, message =>
            {
                Console.WriteLine(message.succes ? "added succesfully" : "unable to add");
                MainPage();
            });
        }

        private static List<CheckIn> checkIns = null;

        private static void ModCheckin()
        {
            int movieID = -1;
            do
            {
                Console.Write("\tmovieId(>0): ");
                int.TryParse(Console.ReadLine().Trim(), out movieID);
            } while (movieID < 0 || checkIns.Exists(checjIn => checjIn.movieId == movieID) == false);

            CheckIn modCheckIn = checkIns.Find(checkIn => checkIn.movieId == movieID);

            int rating = -1;
            do
            {
                Console.Write("\trating(0-10[- ign ! idd]");
                string input = Console.ReadLine().Trim();
                if (input == "-")
                {
                    rating = int.MinValue;
                    break;
                }
                if (input == "!")
                {
                    rating = int.MaxValue;
                    break;
                }
                int.TryParse(Console.ReadLine().Trim(), out rating);
            } while (rating < 0 || rating > 10);

            Console.Write("\tdescription [! idd]: ");
            string description = Console.ReadLine().Trim();
            if (description == "!") description = modCheckIn.description;

            modCheckIn.rating = rating == int.MinValue
                ? null
                : rating == int.MaxValue ? modCheckIn.rating : (byte) rating;
            modCheckIn.description = description;

            ServerHandler.instance.SendMessage(new Message
            {
                traceNumber = TraceID.GenerateTraceID(),
                type = Message.Type.UserData.CheckIn.modify,
                isResponse = false,
                succes = true,
                message = new
                {
                    userid = _userid,
                    checkIn = modCheckIn.Serialize()
                }
            }, message =>
            {
                Console.WriteLine(message.succes ? "mod succsesfull" : "mod unsuccessfull");
                MainPage();
            });
        }
    }
}
