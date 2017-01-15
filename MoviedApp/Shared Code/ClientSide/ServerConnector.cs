using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared_Code;

namespace Shared_Code.Client_Side
{
    public class ServerConnector
    {
        public enum Response
        {
            SUCCES,
            NOT_CONNECTED
        }

        public static readonly ServerConnector instance = new ServerConnector();

        private readonly object serverLocable = new object();
        private NetworkStream server = null;

        public bool IsConnected
        {
            get
            {
                lock (serverLocable)
                {
                    return server != null;
                }
            }
        }

        public Action<Message> OnMessageRecieved = message => Console.WriteLine("message recieved: " + message);
        public Action OnConnection = () => Console.WriteLine("connction established");

        private Mutex writeMutex = new Mutex(false);

        private ServerConnector()
        {
        }

        private bool initialized = false;
        public void Init()
        {
            if (initialized)
                throw new Exception("init may be called only once");
            TraceID.localID = NodeAddress.None;
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
            lock (serverLocable)
            {
                this.server = server.GetStream();
            }
            OnConnection();
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
            while (true)
                OnMessageRecieved(IOHandler.Read(server));
        }
    }
}
