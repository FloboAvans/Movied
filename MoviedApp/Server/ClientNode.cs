﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Code;

namespace Server
{
    class ClientNode : Node
    {
        public enum State
        {
            START = 0,
            LOGIN = 1,
            ACTIVE =2,
            CLOSING_DOWN = 3,
            CLOSED = 4
        }

        public const int ID_UNKNOWN = -1;

        public int userID = ID_UNKNOWN;
        public State state = State.START;

        public ClientNode(Queue<Message> inQueue) : base(MessageHandler, inQueue)
        {

        }

        private static NodeResponse MessageHandler(Node node, Message message)
        {
            if (typeof(ClientNode) != node.GetType())
                return NodeResponse.MES_NODE_MISMATCH;

            ClientNode clientNode = (ClientNode) node;

            switch (clientNode.state)
            {
                case State.START:
                    throw new Exception("state should never be START");
                    break;
                case State.LOGIN:

                    break;
            }
        }
    }
}
