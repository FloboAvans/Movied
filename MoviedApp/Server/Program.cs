using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Code;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordNode.Init();
            ClientListner.Init();
        }
    }
}
