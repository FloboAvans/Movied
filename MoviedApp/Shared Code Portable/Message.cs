﻿using System;
using Newtonsoft.Json.Linq;
using Shared_Code;

namespace Shared_Code_Portable
{

    public struct Message
    {
        public sealed class Type
        {
            private Type()
            {
            }

            public static readonly ID<Type> clientServer = 1;
            public static class ClientServer
            {
                public static readonly ID<Type> login = clientServer[0];
                public static class Login
                {
                    public static readonly ID<Type> saltRequest = login[0];
                    public static readonly ID<Type> createUser = login[1];
                    public static readonly ID<Type> setHash = login[2];
                    public static readonly ID<Type> checkHash = login[3];
                    public static readonly ID<Type> alreadyLogedIn = login[4];
                }

                public static readonly ID<Type> error = clientServer[1];
                public static class Error
                {
                    public static readonly ID<Type> connectionException = error[0];
                }

                public static readonly ID<Type> utility = clientServer[2];
                public static class Utility
                {
                    public static readonly ID<Type> shutdown = utility[0];
                }

                public static readonly ID<Type> handshake = clientServer[3];
            }
        }

        public const int ID_UNKNOWN = 0;

        public NodeAddress senderID;
        public NodeAddress destinationID;
        public TraceID traceNumber;
        public ID<Type> type;
        public bool succes;
        public bool isResponse;
        public dynamic message;

        public Message(NodeAddress senderID, NodeAddress destinationID, TraceID traceNumber, ID<Type> type, bool succes, bool isResponse, dynamic message)
        {
            this.senderID = senderID;
            this.destinationID = destinationID;
            this.traceNumber = traceNumber;
            this.type = type;
            this.succes = succes;
            this.isResponse = isResponse;
            this.message = message;
        }

        public Message(JObject jObject)
        {
            senderID = (UniqeRandomNumber) (ulong) jObject["senderID"];
            destinationID = (UniqeRandomNumber) (ulong) jObject["destinationID"];
            JToken prop = jObject["traceNumber"];
            traceNumber = Convert.FromBase64String((string) jObject["traceNumber"]);
            type = new ID<Type>((JObject)jObject["type"]);
            succes = (bool) jObject["succes"];
            isResponse = (bool) jObject["isResponse"];
            JToken messageToken;
            if (jObject.TryGetValue("message", out messageToken))
                message = messageToken;
            else
                message = null;
        }

        public JObject Serialize()
        {
            JObject jObject = new JObject();
            jObject.Add("senderID", (ulong)(UniqeRandomNumber)senderID);
            jObject.Add("destinationID", (ulong)(UniqeRandomNumber)destinationID);
            jObject.Add("traceNumber", Convert.ToBase64String(traceNumber));
            jObject.Add("type", type.Serialize());
            jObject.Add("succes", succes);
            jObject.Add("isResponse", isResponse);
            if (message != null) jObject.Add("message", JObject.FromObject(message));
            return jObject;
        }

        public override string ToString()
        {
            return $"sID={senderID}, dID={destinationID}, trace={traceNumber}, m={type}, valid={succes}, response={isResponse}, message={message}";
        }
    }
}
