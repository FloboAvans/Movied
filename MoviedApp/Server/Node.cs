using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared_Code;
using Shared_Code_Portable;

namespace Server
{
    class Node
    {
        private Queue<Message> inQueue;
        private Dictionary<TraceID, Func<Message, ID<NodeResponse>>> messageTracer = new Dictionary<TraceID, Func<Message, ID<NodeResponse>>>();
        public readonly NodeAddress Id;
        public Action<ID<NodeResponse>, Message, Node> OnError = (r, m, n) => Console.WriteLine($"ERROR: {r} on [{m}] by {n.Id}");

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
                public static readonly ID<NodeResponse> traceFault = preCheck[2];
            }

            public static readonly ID<NodeResponse> clientNode = 4;
            public static class ClientNode
            {
                public static readonly ID<NodeResponse> invalidState = clientNode[0];
                public static readonly ID<NodeResponse> connectionExecption = clientNode[1];
            }

            public static readonly ID<NodeResponse> postBox = 5;
            public static class PostBox
            {
                public static readonly ID<NodeResponse> unableToSendMessage = postBox[0];
            }
        }

        public Node(Func<Node, Message, ID<NodeResponse>> messageHandler, NodeAddress id)
        {
            if (messageHandler == null)
                throw new ArgumentNullException("messageHandler may not be NULL");

            Id = id == NodeAddress.None ? NodeAddress.Generate() : id;

            PostBox.Response response = PostBox.instance.AddTarget(this);
            if (response != PostBox.Response.SUCCESS)
                throw new ArgumentException($"PostBox gave a \"{response}\" on id \"{Id}\" during Node()");

            Console.WriteLine($"new node, id={Id}, type={GetType().Name}");

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
            if (message.destinationID != Id && message.destinationID != NodeAddress.None)
                return NodeResponse.PreCheck.nodeMismatch;
            return NodeResponse.succes;
        }

        protected void AddTrace(Message m, Func<Message, ID<NodeResponse>> OnMessage)
        {
            if (OnMessage == null)
                throw new ArgumentNullException("OnMessage may not be null");

            if (messageTracer.ContainsKey(m.traceNumber))
                throw new InvalidOperationException("trace already exists");

            messageTracer.Add(m.traceNumber, OnMessage);
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
                        else if (messageTracer.ContainsKey(m.traceNumber))
                        {
                            Func<Message, ID<NodeResponse>> OnMessage;
                            if (messageTracer.TryGetValue(m.traceNumber, out OnMessage) == false)
                                OnError(NodeResponse.PreCheck.traceFault, m, this);
                            else
                            {
                                messageTracer.Remove(m.traceNumber);
                                if ((response = OnMessage(m)) != NodeResponse.succes)
                                    OnError(response, m, this);
                            }
                        }
                        else if ((response = messageHandler(this, m)) != NodeResponse.succes)
                            OnError(response, m, this);
                    }
                }
                Thread.Yield();        
            }
        }
    }
}
