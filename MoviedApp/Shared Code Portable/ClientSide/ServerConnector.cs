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

        private async void ConnectionEstablisher()
        {
            TcpSocketClient server = null;
            do
            {
                try
                {
                    server = new TcpSocketClient();
                    await server.ConnectAsync(Constants.Network.HOST_IP, Constants.Network.HOST_PORT);
                }
                catch (Exception)
                {
                    server = null;
                }
            } while (server == null);
            toServer = server.WriteStream;
            Stream fromServer = server.ReadStream;

            OnConnection();

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    OnMessageRecieved(IOHandler.Read(fromServer));
                }
            });
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
