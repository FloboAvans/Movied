using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    public struct Message
    {
        public readonly int senderID;
        public readonly int destinationID;
        public readonly string messageName;
        public readonly bool isValid;
        public readonly dynamic message;

        public Message(int senderID, int destinationID, string messageName, bool isValid, dynamic message)
        {
            if (messageName == null || messageName.Trim() == "")
                throw new ArgumentException("messageName is null or \"\"");

            this.senderID = senderID;
            this.destinationID = destinationID;
            this.messageName = messageName;
            this.isValid = isValid;
            this.message = message;
        }

        public override string ToString()
        {
            return $"sID={senderID}, dID={destinationID}, mn={messageName}, valid={isValid}";
        }
    }
}
