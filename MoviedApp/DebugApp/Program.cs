using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private static void LoginHandler()
        {
            string mode;
            do
            {
                Console.WriteLine("\"login\" or \"create\"");
                mode = Console.ReadLine();
            } while (mode != "login" && mode != "create");
            if (mode == "login") Login1();
            else Create();
        }

        private static void Login1()
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
                }, m1 =>
                {
                    if (m1.succes = false)
                    {
                        Console.WriteLine("username does not exist");
                        Login1();
                    }
                    else
                    {
                        byte[] saltBytes = Convert.FromBase64String((string) m1.message.salt);
                        Console.WriteLine("salt extracted");
                    }
                });
        }

        private static void Create()
        {
            
        }
    }
}
