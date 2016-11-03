using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Code;

namespace MoviedApp
{
    class ServerHandler
    {
        public static readonly ServerHandler instance = new ServerHandler();

        private enum State
        {
            NOT_STARTED,
            CONNECTING,
            HANDSHAKE,
            ACTIVE,
            CLOSED
        }

        public int clientID = Message.ID_UNKNOWN;
        public int serverNodeID = Message.ID_UNKNOWN;

        private State state = State.NOT_STARTED;

        private Dictionary<ulong, Action<Message>> resultDictionary = new Dictionary<ulong, Action<Message>>();

        public Action OnHandshakeComplete = () => Console.WriteLine("handshake complete");

        private ServerHandler()
        {
            ServerConnector.instance.OnConnection += () => ++state; ServerConnector.instance.SendMessage(new Message(
                Message.ID_UNKNOWN,
                Message.ID_UNKNOWN,
                0,
                Message.Type.ClientServer.handshake,
                true,
                false,
                null));

            ServerConnector.instance.OnMessageRecieved += MessageHandler;
            ServerConnector.instance.Init();
            ++state;
        }

        private void MessageHandler(Message message)
        {
            switch (state)
            {
                case State.HANDSHAKE:
                    if (message.type != Message.Type.ClientServer.handshake)
                    {
                        Console.WriteLine($"unexpected message, state={state}, message={message}");
                        return;
                    }
                    if (message.succes == false)
                    {
                        Console.WriteLine($"connection was blocked, message={message}");
                    }
                    clientID = message.message.clientid;
                    serverNodeID = message.senderID;
                    OnHandshakeComplete();
                    ++state;
                    return;
                case State.ACTIVE:
                    Action<Message> messageCallback;
                    lock (resultDictionary)
                    {
                        if (resultDictionary.TryGetValue(message.traceNumber, out messageCallback) == false)
                        {
                            Console.WriteLine($"traceID not found, message={message}");
                            return;
                        }
                        resultDictionary.Remove(message.traceNumber);
                    }
                    messageCallback(message);
                    return;
                default:
                    Console.WriteLine($"state mismatch, state={state}, message={message}");
                    break;
            }
        }

        public bool SendMessage(Message message, Action<Message> OnResponse)
        {
            if (state != State.ACTIVE)
                return false;

            lock (resultDictionary)
            {
                if (resultDictionary.ContainsKey(message.traceNumber))
                    return false;
                resultDictionary.Add(message.traceNumber, OnResponse);
            }

            ServerConnector.instance.SendMessage(message);
            return true;
        }
    }
}
