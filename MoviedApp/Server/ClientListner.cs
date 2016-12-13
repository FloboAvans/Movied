using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared_Code;

namespace Server
{
    class ClientListner
    {
        public static ClientListner instance = new ClientListner();

        public static void Init() { }

        private ClientListner()
        {
            if (instance != null)
                throw new Exception("ClientListner uses the singelton pattern");
            instance = this;
            new Thread(Listner).Start();
        }

        private void Listner()
        {
            TcpListener listner = new TcpListener(Dns.GetHostAddresses(Constants.Network.HOST_IP)[0], Constants.Network.HOST_PORT);
            listner.Start();
            while (true)
            {
                TcpClient client = listner.AcceptTcpClient();
                new ClientNode(client);
            }
        }
    }
}
