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

            PasswordNode passwordNode = (PasswordNode) node;

            if (message.type == Message.Type.ClientServer.Login.saltRequest)
            {
                byte[] saltBytes;
                PasswordBank.Response response;
                if (message.message.mode == true)
                    response = passwordNode.passwordBank.GetSalt((string) message.message.username, out saltBytes);
                else
                    response = passwordNode.passwordBank.GetSalt((int) message.message.userid, out saltBytes);

                Message returnMessage;
                if (response == PasswordBank.Response.SUCCES)
                    returnMessage = new Message(
                        passwordNode.Id,
                        message.senderID,
                        message.traceNumber,
                        message.type,
                        true,
                        true,
                        new {salt = Convert.ToBase64String(saltBytes)});
                else
                    returnMessage = new Message(
                        passwordNode.Id,
                        message.senderID,
                        message.traceNumber,
                        message.type,
                        false,
                        true,
                        new {response = response});

                PostBox.instance.PostMessage(returnMessage);
            }
            return NodeResponse.succes;
        }
    }
}
