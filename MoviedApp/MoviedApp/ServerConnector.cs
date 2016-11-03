using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared_Code;

namespace MoviedApp
{
    class ServerConnector
    {
        public enum Response
        {
            SUCCES,
            NOT_CONNECTED
        }

        public static readonly ServerConnector instance = new ServerConnector();

        private NetworkStream server = null;

        public bool IsConnected
        {
            get
            {
                lock (server)
                {
                    return server != null;
                }
            }
        }

        public Action<Message> OnMessageRecieved = message => Console.WriteLine("message recieved: " + message);

        private Mutex writeMutex = new Mutex(false);

        private ServerConnector()
        {
            new Thread(ConnectionEstablisher).Start();
        }

        private void ConnectionEstablisher()
        {
            TcpClient server = null;
            do
            {
                try
                {
                    server = new TcpClient(Constants.Network.HOST_IP, Constants.Network.HOST_PORT);
                }
                catch (Exception) { Thread.Sleep(250); }
            } while (server == null);
            lock (this.server)
            {
                this.server = server.GetStream();
            }

            new Thread(Reader).Start();
        }

        public Response SendMessage(Message message)
        {
            if (IsConnected == false) return Response.NOT_CONNECTED;

            writeMutex.WaitOne();
            try
            {
                IOHandler.Write(server, message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                writeMutex.ReleaseMutex();
            }

            return Response.SUCCES;
        }

        private void Reader()
        {
            OnMessageRecieved(IOHandler.Read(server));
        }
    }
}
