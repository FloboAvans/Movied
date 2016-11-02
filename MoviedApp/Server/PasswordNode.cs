using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashingTest;
using Newtonsoft.Json;
using Shared_Code;

namespace Server
{
    class PasswordNode : Node
    {
        public static PasswordNode instance = new PasswordNode();

        private PasswordBank passwordBank;

        private PasswordNode() : base(MessageHandler)
        {
            if (File.Exists("passwords.pswrd"))
                passwordBank = JsonConvert.DeserializeObject<PasswordBank>(File.ReadAllText("passwords.pswrd"));
            else
                passwordBank = new PasswordBank("admin");
        }

        private static ID<NodeResponse> MessageHandler(Node node, Message message)
        {
            if (node.GetType() != typeof(PasswordNode))
                return NodeResponse.PreCheck.nodeMismatch;

            return NodeResponse.succes;
        }
    }
}
