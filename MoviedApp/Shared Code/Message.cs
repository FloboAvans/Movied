using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
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
                }
            }
        }

        public readonly int senderID;
        public readonly int destinationID;
        public readonly ID<Type> type;
        public readonly bool isValid;
        public readonly bool isResponse;
        public readonly dynamic message;

        public Message(int senderID, int destinationID, ID<Type> type, bool isValid, bool isResponse, dynamic message)
        {
            this.senderID = senderID;
            this.destinationID = destinationID;
            this.type = type;
            this.isValid = isValid;
            this.isResponse = isResponse;
            this.message = message;
        }

        public override string ToString()
        {
            return $"sID={senderID}, dID={destinationID}, m={type}, valid={isValid}, response={isResponse}, message={message}";
        }
    }
}
