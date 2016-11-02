using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared_Code;

namespace Server
{
    public class Node
    {
        public static class Identifier
        {
            public const int UNKNOWN_EDGE = 0;

            private static Mutex serverMutex = new Mutex(false);
            private static Mutex clientMutex = new Mutex(false);
            private static int serverNodeID = 1;
            private static int clientNodeID = -1;

            public static bool IsServerNode(int id)
            {
                return id > 0;
            }

            public static bool IsUserID(int id)
            {
                return IsServerNode(id) ? id%2 == 0 : false;
            }

            public static int GenerateServerID()
            {
                serverMutex.WaitOne();
                try
                {
                    return serverNodeID++<<1;
                }
                finally
                {
                    serverMutex.ReleaseMutex();
                }
            }

            public static int GenerateClientID()
            {
                clientMutex.WaitOne();
                try
                {
                    return clientNodeID--;
                }
                finally
                {
                    clientMutex.ReleaseMutex();
                }
            }
        }

        private Queue<Message> inQueue;

        public readonly int Id = Identifier.GenerateServerID();
        public Action<ID<NodeResponse>, Message, Node> OnError = (r, m, n) => Console.WriteLine($"{r} on [{m}] by {n.Id}");

        public sealed class NodeResponse
        {
            private NodeResponse()
            {
            }

            public static readonly ID<NodeResponse> succes = 1;
            public static readonly ID<NodeResponse> messageTypeMismatch = 2;
            public static readonly ID<NodeResponse> preCheck = 3;
            public static class PreCheck
            {
                public static readonly ID<NodeResponse> destinationMismatch = preCheck[0];
                public static readonly ID<NodeResponse> nodeMismatch = preCheck[1];
            }

            public static readonly ID<NodeResponse> clientNode = 4;
            public static class ClientNode
            {
                public static readonly ID<NodeResponse> invalidState = clientNode[0];
                public static readonly ID<NodeResponse> connectionExecption = clientNode[1];
            }


        }

        public Node(Func<Node, Message, ID<NodeResponse>> messageHandler)
        {
            if (messageHandler == null)
                throw new ArgumentNullException("messageHandler may not be NULL");

            this.inQueue = new Queue<Message>();

            new Thread(() => MessageLoop(messageHandler)).Start();
        }

        public void AddMessage(Message m)
        {
            lock(inQueue)
            {
                inQueue.Enqueue(m);
            }
        }

        private ID<NodeResponse> CheckValidity(Message message)
        {
            if (message.destinationID != Id)
                return NodeResponse.PreCheck.nodeMismatch;
            return NodeResponse.succes;
        }

        private void MessageLoop(Func<Node, Message, ID<NodeResponse>> messageHandler)
        {
            while (true)
            {
                lock (inQueue)
                {
                    int count = inQueue.Count();
                    for (int i = 0; i < count; ++i)
                    {
                        Message m = inQueue.Dequeue();
                        ID<NodeResponse> response;
                        if ((response = CheckValidity(m)) != NodeResponse.succes)
                            OnError(response, m, this);
                        else
                            if ((response = messageHandler(this, m)) != NodeResponse.succes)
                                OnError(response, m, this);
                    }
                }
                Thread.Yield();        
            }
        }
    }
}
