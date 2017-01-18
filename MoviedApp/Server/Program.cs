using System;
using System.Collections.Generic;
using System.Linq;
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
            TraceID.localID = Constants.Network.SERVER_NODE_ADDRESS;
            PasswordNode.Init();
            ClientListner.Init();
        }
    }
}
