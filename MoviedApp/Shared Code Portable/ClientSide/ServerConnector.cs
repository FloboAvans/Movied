using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Shared_Code;
using Sockets.Plugin;

namespace Shared_Code_Portable.ClientSide
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
        private Stream toServer = null;

        public bool IsConnected
        {
            get
            {
                lock (serverLocable)
                {
                    return toServer != null;
                }
            }
        }

        public static bool printMessages = true;

        public Action<Message> OnMessageRecieved;
        public Action OnConnection = () => Debug.WriteLine("connction established");


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
            Task.Factory.StartNew(ConnectionEstablisher);
        }

        private void ConnectionEstablisher()
        {
            TcpSocketListener server = new TcpSocketListener();
            server.ConnectionReceived += (sender, args) =>
            {
                var Client = args.SocketClient;
                var fromServer = Client.ReadStream;
                toServer = Client.WriteStream;

                while (true)
                {
                    OnMessageRecieved(IOHandler.Read(fromServer));
                }
            };
            server.StartListeningAsync(Constants.Network.HOST_PORT);
        }

        public Response SendMessage(Message message)
        {
            if (IsConnected == false) return Response.NOT_CONNECTED;

            writeMutex.WaitOne();
            try
            {
                IOHandler.Write(toServer, message);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                writeMutex.ReleaseMutex();
            }

            return Response.SUCCES;
        }
    }
}
