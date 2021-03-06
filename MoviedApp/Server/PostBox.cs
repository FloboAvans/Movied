﻿using Shared_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Shared_Code_Portable;

namespace Server
{
    [Serializable]
    class PostBox : ISerializable
    {
        public static PostBox instance = Init();

        private static PostBox Init()
        {
            // TODO implement serilzation 
            return new PostBox();
        }

        public enum TargetState
        {
            NON_EXISTENT,
            ACTIVE,
            TANSFORMING,
            INACTIVE
        }

        public enum Response
        {
            SUCCESS,
            NO_SUTCH_TARGET,
            TARGET_EXISTS,
            TARGET_IS_ACTIVE,
            TARGET_IS_TRANSFORMING,
            TARGET_ISNOT_TRANSFORMING,
            TARGET_IS_INACTIVE,
            __INTERNAL_NO_TARGET,
            __INTERNAL_TWO_TARGETS
        }

        private class Entry
        {
            public Node node;
            public Queue<Message> inQueue;
            public bool IsActivating;

            public Entry(Node node, Queue<Message> inQueue)
            {
                this.node = node;
                this.inQueue = inQueue;
                IsActivating = false;
            }

            public Response Check()
            {

                if (node == null && inQueue == null)
                    if (IsActivating == false)
                        return Response.__INTERNAL_NO_TARGET;
                    else
                        return Response.TARGET_IS_TRANSFORMING;
                if (node != null && inQueue != null)
                    return Response.__INTERNAL_TWO_TARGETS;
                return Response.SUCCESS;
            }
        }

        private Dictionary<NodeAddress, Entry> postBox;

        private PostBox()
        {
            postBox = new Dictionary<NodeAddress, Entry>();
        }

        private PostBox(SerializationInfo info, StreamingContext context)
        {
            postBox = (Dictionary<NodeAddress, Entry>) info.GetValue("postBox", postBox.GetType());
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //TODO fix this
            //info.AddValue("postBox", postBox.Where(a => Node.Identifier.IsUserID(a.Key)));
        }

        public TargetState GeTargetState(NodeAddress id)
        {
            lock (postBox)
            {
                Entry entry;
                if (postBox.TryGetValue(id, out entry) == false)
                    return TargetState.NON_EXISTENT;
                if (entry.IsActivating)
                    return TargetState.TANSFORMING;
                if (entry.node != null)
                    return TargetState.ACTIVE;
                return TargetState.INACTIVE;
            }
        }

        public Response TargetExists(NodeAddress id)
        {
            lock (postBox)
            {
                if (postBox.ContainsKey(id))
                    return Response.SUCCESS;
                return Response.NO_SUTCH_TARGET;
            }
        }

        public Response PostMessage(Message message)
        {
            lock (postBox)
            {
                Entry entry;
                if (postBox.TryGetValue(message.destinationID, out entry) == false)
                    return Response.NO_SUTCH_TARGET;
                Response response;
                if ((response = entry.Check()) != Response.SUCCESS)
                    return response;
                if (entry.node != null)
                    entry.node.AddMessage(message);
                else
                    entry.inQueue.Enqueue(message);
                return Response.SUCCESS;
            }
        }

        public Response AddTarget(NodeAddress id, Node node = null)
        {
            lock (postBox)
            {

                if (postBox.ContainsKey(id))
                    return Response.TARGET_EXISTS;
                if (node == null)
                    postBox.Add(id, new Entry(null, new Queue<Message>()));
                else
                    postBox.Add(id, new Entry(node, null));
                return Response.SUCCESS;
            }
        }

        public Response AddTarget(Node node)
        {
            lock (postBox)
            {
                if (postBox.ContainsKey(node.Id))
                    return Response.TARGET_EXISTS;
                postBox.Add(node.Id, new Entry(node, null));
                return Response.SUCCESS;
            }
        }

        public Response ActivateTargetStep1(NodeAddress id, out Queue<Message> inQueue)
        {
            inQueue = null;
            lock (postBox)
            {
                Entry entry;
                if (postBox.TryGetValue(id, out entry) == false)
                    return Response.NO_SUTCH_TARGET;
                Response response;
                if ((response = entry.Check()) != Response.SUCCESS)
                    return response;
                if (entry.node != null)
                    return Response.TARGET_IS_ACTIVE;
                inQueue = entry.inQueue;
                entry.inQueue = null;
                entry.IsActivating = true;
                return Response.SUCCESS;
            }
        }

        public Response ActivateTargetStep2(Node node)
        {
            lock (postBox)
            {
                Entry entry;
                if (postBox.TryGetValue(node.Id, out entry))
                    return Response.NO_SUTCH_TARGET;
                if (entry.Check() != Response.TARGET_IS_TRANSFORMING)
                    return Response.TARGET_ISNOT_TRANSFORMING;
                entry.node = node;
                entry.IsActivating = false;
                return Response.SUCCESS;
            }  
        }

        public Response DeactivateTarget(NodeAddress id, Queue<Message> inQueue)
        {
            lock (postBox)
            {
                Entry entry;
                if (postBox.TryGetValue(id, out entry) == false)
                    return Response.NO_SUTCH_TARGET;
                Response response;
                if ((response = entry.Check()) != Response.SUCCESS)
                    return response;
                if (entry.inQueue != null)
                    return Response.TARGET_IS_INACTIVE;
                entry.node = null;
                entry.inQueue = inQueue ?? new Queue<Message>();
                return Response.SUCCESS;
            }
        }

        public Response RemoveTarget(NodeAddress id)
        {
            lock (postBox)
            {
                if (postBox.ContainsKey(id) == false)
                    return Response.NO_SUTCH_TARGET;
                postBox.Remove(id);
                return Response.SUCCESS;
            }
        }
    }
}
