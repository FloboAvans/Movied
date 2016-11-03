using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Code;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClientListner();
            PasswordNode.Init();

            Console.WriteLine($"Message.Type.ClientServer.handshake ={Message.Type.ClientServer.handshake.ToString<Message.Type>()}");
        }
    }
}
