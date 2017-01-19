using System;
using System.Collections.Generic;
using System.Diagnostics;
using Shared_Code;

namespace Shared_Code_Portable.ClientSide
{
    public class ServerHandler
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

        public NodeAddress clientID = NodeAddress.None;
        public NodeAddress serverNodeID = NodeAddress.None;

        private State state = State.NOT_STARTED;

        private Dictionary<TraceID, Action<Message>> resultDictionary = new Dictionary<TraceID, Action<Message>>();

        public Action OnHandshakeComplete = () => Debug.WriteLine("handshake complete");

        private ServerHandler()
        {
            ServerConnector.instance.OnConnection += () =>
            {
                ++state;
                ServerConnector.instance.SendMessage(new Message(
                    NodeAddress.None, 
                    NodeAddress.None, 
                    TraceID.None, 
                    Message.Type.ClientServer.handshake,
                    true,
                    false,
                    null));
            };

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
                        Debug.WriteLine($"unexpected message, state={state}, message={message}");
                        return;
                    }
                    if (message.succes == false)
                    {
                        Debug.WriteLine($"connection was blocked, message={message}");
                    }
                    TraceID.localID = clientID = (UniqeRandomNumber)ulong.Parse(((string)message.message.clientid).Substring(1));
                    serverNodeID = message.senderID;
                    ++state;
                    OnHandshakeComplete();
                    return;
                case State.ACTIVE:
                    Action<Message> messageCallback;
                    lock (resultDictionary)
                    {
                        if (resultDictionary.TryGetValue(message.traceNumber, out messageCallback) == false)
                        {
                            Debug.WriteLine($"traceID not found, message={message}");
                            return;
                        }
                        resultDictionary.Remove(message.traceNumber);
                    }
                    messageCallback(message);
                    return;
                default:
                    Debug.WriteLine($"state mismatch, state={state}, message={message}");
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
