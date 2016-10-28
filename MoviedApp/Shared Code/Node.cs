using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared_Code
{
    public class Node
    {
        private Queue<Message> inQueue;

        private static int NodeIdCounter = 1;
        public readonly int Id = NodeIdCounter++;
        public Action<NodeResponse, Message, Node> OnError = (r, m, n) => Console.WriteLine($"{r} on [{m}] by {n.Id}");

        public enum NodeResponse
        {
            SUCCES,
            DESTINATION_MISMATCH,
            MES_UNKNOWN,
            MES_NODE_MISMATCH
        }

        public Node(Func<Node, Message, NodeResponse> messageHandler, Queue<Message> inQueue)
        {
            if (messageHandler == null)
                throw new ArgumentNullException("messageHandler may not be NULL");

            this.inQueue = inQueue ?? new Queue<Message>();

            new Thread(() => MessageLoop(messageHandler)).Start();
        }

        public void AddMessage(Message m)
        {
            lock(inQueue)
            {
                inQueue.Enqueue(m);
            }
        }

        private NodeResponse CheckValidity(Message message)
        {
            if (message.destinationID != Id)
                return NodeResponse.DESTINATION_MISMATCH;
            return NodeResponse.SUCCES;
        }

        private void MessageLoop(Func<Node, Message, NodeResponse> messageHandler)
        {
            while (true)
            {
                lock (inQueue)
                {
                    int count = inQueue.Count();
                    for (int i = 0; i < count; ++i)
                    {
                        Message m = inQueue.Dequeue();
                        NodeResponse response;
                        if ((response = CheckValidity(m)) != NodeResponse.SUCCES)
                            OnError(response, m, this);
                        else
                            if ((response = messageHandler(this, m)) != NodeResponse.SUCCES)
                                OnError(response, m, this);
                    }
                }
                Thread.Yield();        
            }
        }
    }
}
