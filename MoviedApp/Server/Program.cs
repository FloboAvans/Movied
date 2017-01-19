using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Shared_Code;
using Shared_Code_Portable;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            UniqeRandomNumber.makeRandom = i =>
            {
                byte[] bytes = new byte[i];
                rng.GetBytes(bytes);
                return bytes;
            };
            ID<Message.Type>.ToStringer += id => IDToString.ToString<Message.Type>(id, typeof(Message.Type));
            TraceID.localID = Constants.Network.SERVER_NODE_ADDRESS;
            PasswordNode.Init();
            ClientListner.Init();
        }
    }
}
