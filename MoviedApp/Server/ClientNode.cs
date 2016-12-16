﻿using System;
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
        public enum State
        {
            START,
            HANDSHAKE,
            LOGIN,
            ACTIVE,
            CLOSING_DOWN,
            CLOSED
        }

        public const int ID_UNKNOWN = -1;

        public int userID = ID_UNKNOWN;
        public int clientID = Identifier.GenerateClientID();
        public State state = State.START;

        private NetworkStream client;

        public ClientNode(TcpClient client) : base(MessageHandler)
        {
            if (client == null)
                throw new ArgumentNullException("client may not be null");
            if (client.Connected == false)
                throw new ArgumentException("client needs to be connected");

            this.client = client.GetStream();
            new Thread(ReadFromClient).Start();

            ++state;
        }

        private void ReadFromClient()
        {
            try
            {
                while (true)
                {
                    Message message = IOHandler.Read(client);
                    //Console.WriteLine($"clientNode {Id} recieved message \n\t{message}");
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
                Console.WriteLine($"clientNode {Id} recieved exception\n\t{e.GetType().Name} : {e.Message}");
                AddMessage(exceptionMessage);
            }
        }

        private void WriteToClient(Message message)
        {
            try
            {
                IOHandler.Write(client, message);
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

            Message forwardMessage = message;
            switch (clientNode.state)
            {
                case State.START:
                    throw new Exception("state should never be START");
                case State.HANDSHAKE:
                    forwardMessage.destinationID = clientNode.clientID;
                    forwardMessage.senderID = clientNode.Id;
                    forwardMessage.isResponse = true;

                    if (message.type != Message.Type.ClientServer.handshake)
                    {
                        forwardMessage.succes = false;
                        clientNode.WriteToClient(forwardMessage);
                        return NodeResponse.messageTypeMismatch;
                    }

                    forwardMessage.succes = true;
                    forwardMessage.message = new {clientid = clientNode.clientID};
                    ++clientNode.state;
                    clientNode.WriteToClient(forwardMessage);
                    return NodeResponse.succes;
                case State.LOGIN:
                    #region LOGIN
                    if (message.type.isa(Message.Type.ClientServer.login) == false)
                        return NodeResponse.messageTypeMismatch;
                    if (message.type.isa(Message.Type.ClientServer.login))
                    {
                        if (message.isResponse == false)
                        {
                            forwardMessage.senderID = node.Id;
                            forwardMessage.destinationID = Node.Identifier.PASSWORD_NODE;
                        }
                        else if ((message.type == Message.Type.ClientServer.Login.checkHash ||
                                  message.type == Message.Type.ClientServer.Login.setHash) &&
                                 message.succes)
                        {
                            forwardMessage.destinationID = clientNode.clientID;
                            forwardMessage.senderID = clientNode.Id;
                            PostBox.TargetState targetState = PostBox.instance.GeTargetState((int)message.message.userid);
                            switch (targetState)
                            {
                                case PostBox.TargetState.ACTIVE:
                                case PostBox.TargetState.TANSFORMING:
                                    forwardMessage.type = Message.Type.ClientServer.Login.alreadyLogedIn;
                                    break;
                                case PostBox.TargetState.INACTIVE:
                                    Queue<Message> messages;
                                    PostBox.Response response =
                                        PostBox.instance.ActivateTargetStep1(message.message.userid, out messages);
                                    if (response != PostBox.Response.SUCCESS)
                                        forwardMessage.type = Message.Type.ClientServer.Login.alreadyLogedIn;
                                    else
                                    {
                                        foreach (
                                            Message m in
                                            messages.Where(m => m.type != Message.Type.ClientServer.Utility.shutdown))
                                            clientNode.AddMessage(m);
                                        clientNode.userID = message.message.userid;
                                        if ((response = PostBox.instance.ActivateTargetStep2(clientNode)) !=
                                            PostBox.Response.SUCCESS)
                                            forwardMessage.type = Message.Type.ClientServer.Login.alreadyLogedIn;
                                        else
                                        {
                                            ++clientNode.state;
                                        }
                                    }
                                    break;
                                case PostBox.TargetState.NON_EXISTENT:
                                    if (PostBox.instance.AddTarget((int)message.message.userid,clientNode) != PostBox.Response.SUCCESS)
                                        forwardMessage.type = Message.Type.ClientServer.Login.alreadyLogedIn;
                                    else
                                    {
                                        clientNode.userID = message.message.userid;
                                        ++clientNode.state;
                                    }

                                    break;
                            }
                            clientNode.WriteToClient(forwardMessage);
                        }
                        else
                        {
                            forwardMessage.destinationID = clientNode.clientID;
                            forwardMessage.senderID = clientNode.Id;
                            clientNode.WriteToClient(forwardMessage);
                            return NodeResponse.succes;
                        }
                        PostBox.instance.PostMessage(forwardMessage);
                        return NodeResponse.succes;
                    }

                    #endregion
                    break;
            }

            return NodeResponse.succes;
        }
    }
}
