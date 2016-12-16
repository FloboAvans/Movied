using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared_Code
{
#if WINDOWS_UWP
    public struct Message
#else
    [Serializable]
    public struct Message
#endif
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

        public int senderID;
        public int destinationID;
        public TraceID traceNumber;
        public ID<Type> type;
        public bool succes;
        public bool isResponse;
        public dynamic message;

        public Message(int senderID, int destinationID, TraceID traceNumber, ID<Type> type, bool succes, bool isResponse, dynamic message)
        {
            this.senderID = senderID;
            this.destinationID = destinationID;
            this.traceNumber = traceNumber;
            this.type = type;
            this.succes = succes;
            this.isResponse = isResponse;
            this.message = message;
        }

        public override string ToString()
        {
            return $"sID={senderID}, dID={destinationID}, trace={traceNumber}, m={type}, valid={succes}, response={isResponse}, message={message}";
        }
    }
}
