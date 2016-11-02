using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Shared_Code;

namespace Server
{
    class ClientNode : Node
    {
        public class ConnectionAbrubtlyLostException : IOException
        {

        }

        public enum State
        {
            START = 0,
            LOGIN = 1,
            ACTIVE = 2,
            CLOSING_DOWN = 3,
            CLOSED = 4
        }

        public const int ID_UNKNOWN = -1;

        public int userID = ID_UNKNOWN;
        public State state = State.START;

        private NetworkStream client;

        #region LOGIN

        private enum LoginState
        {
            NOT_STARTED,
            AWAITING,
            CREATING,
            LOGIN,
            LOGED_IN
        }

        private LoginState loginState = LoginState.NOT_STARTED;

        #endregion

        public ClientNode(TcpClient client) : base(MessageHandler)
        {
            if (client == null)
                throw new ArgumentNullException("client may not be null");
            if (client.Connected == false)
                throw new ArgumentException("client needs to be connected");

            this.client = client.GetStream();
            new Thread(ReadFromClient).Start();
            loginState = LoginState.AWAITING;
            ++state;
        }

        private void ReadFromClient()
        {
            try
            {
                while (true)
                {
                    byte[] lengthBuffer = new byte[Constants.Network.LENGTH_BYTE_SIZE];
                    client.Read(lengthBuffer, 0, lengthBuffer.Length);
                    int lenght = BitConverter.ToInt32(lengthBuffer, 0);
                    if (lenght == Constants.Network.UNKNOWN_ERROR)
                        throw new ConnectionAbrubtlyLostException();

                    byte[] messageBuffer = new byte[lenght];
                    client.Read(messageBuffer, 0, lenght);
                    string messageString = Encoding.UTF8.GetString(messageBuffer);
                    Message message = JsonConvert.DeserializeObject<Message>(messageString);
                    AddMessage(message);
                }
            }
            catch (Exception e)
            {
                Message exceptionMessage = new Message(
                    Id,
                    Id,
                    Message.Trace.GenerateTrace(Constants.Network.SERVER_TRACE_ID),
                    Message.Type.ClientServer.Error.connectionException,
                    true, false,
                    new {exception = e});
                AddMessage(exceptionMessage);
            }
        }

        private void WriteToClient(Message message)
        {
            try
            {
                string messageString = JsonConvert.SerializeObject(message);
                byte[] messageBytes = Encoding.UTF8.GetBytes(messageString);
                byte[] lengthBuffer = BitConverter.GetBytes(messageBytes.Length);

                client.Write(lengthBuffer, 0, lengthBuffer.Length);
                client.Write(messageBytes, 0, messageBytes.Length);
            }
            catch (Exception e)
            {
                AddMessage(new Message(
                    Id,
                    Id,
                    Message.Trace.GenerateTrace(Constants.Network.SERVER_TRACE_ID),
                    Message.Type.ClientServer.Error.connectionException,
                    true,
                    false,
                    new {exception = e, internalMessage = message}));
            }
        }

        private static ID<NodeResponse> MessageHandler(Node node, Message message)
        {
            if (typeof(ClientNode) != node.GetType())
                return NodeResponse.PreCheck.nodeMismatch;

            ClientNode clientNode = (ClientNode) node;

            switch (clientNode.state)
            {
                case State.START:
                    throw new Exception("state should never be START");
                case State.LOGIN:
                    if (message.type.isa(Message.Type.ClientServer.login) == false)
                        return NodeResponse.messageTypeMismatch;


                    break;
            }

            return NodeResponse.succes;
        }
    }
}
