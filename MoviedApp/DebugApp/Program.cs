using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashingTest;
using Shared_Code;
using Shared_Code.Client_Side;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerHandler.instance.OnHandshakeComplete += LoginHandler;
        }

        #region login

        private static void LoginHandler()
        {
            string debug;
            do
            {
                Console.Write("debug mode?['y' or 'n']: ");
                debug = Console.ReadLine();
            } while (debug != "y" && debug != "n");
            if (debug == "y")
                ServerConnector.instance.OnMessageRecieved +=
                    message => Console.WriteLine("message recieved:\r\n\t" + message);

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

        private static void LoginPassword(int userid, byte[] salt, TraceID traceID)
        {
            Console.Write("password: ");
            string password = Console.ReadLine();

            ServerHandler.instance.SendMessage(new Message
            {
                destinationID = ServerHandler.instance.serverNodeID,
                senderID = ServerHandler.instance.clientID,
                traceNumber = traceID,
                isResponse = true,
                succes = true,
                type = Message.Type.ClientServer.Login.checkHash,
                message = new
                {
                    hash = Convert.ToBase64String(PasswordBank.HashPasword(password, salt)),
                    userid = userid
                }
            }, message =>
            {
                if (message.succes)
                {
                    Console.WriteLine("login succesfull");
                    MainPage();
                }
                else
                {
                    LoginPassword(message.message.userid, salt, traceID);
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
                    CreatePassword(message.message.userid, saltBytes, message.traceNumber);
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
                isResponse = true,
                succes = true,
                type = Message.Type.ClientServer.Login.setHash,
                message = new
                {
                    hash = Convert.ToBase64String(PasswordBank.HashPasword(password, salt)),
                    userid = userid
                }
            }, message =>
            {
                Console.WriteLine("account created succesfully");
                MainPage();
            });
        }

        #endregion
        private static void MainPage()
        {
            
        }
    }
}
