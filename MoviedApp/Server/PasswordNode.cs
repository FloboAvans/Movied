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
        private static PasswordNode instance;
        public static void Init() { instance = new PasswordNode();}

        private PasswordBank passwordBank;

        private PasswordNode() : base(MessageHandler, Identifier.PASSWORD_NODE)
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
            Message returnMessage;
            {
                if (message.type == Message.Type.ClientServer.Login.saltRequest)
                {
                    #region SALT_REQUEST
                    byte[] saltBytes;
                    PasswordBank.Response response;

                    response = passwordNode.passwordBank.GetSalt((string) message.message.username, out saltBytes);

                    if (response == PasswordBank.Response.SUCCES)
                        returnMessage = new Message(
                            passwordNode.Id,
                            message.senderID,
                            message.traceNumber,
                            message.type,
                            true,
                            true,
                            new {salt = Convert.ToBase64String(saltBytes), username = (string)message.message.username});
                    else
                        returnMessage = new Message(
                            passwordNode.Id,
                            message.senderID,
                            message.traceNumber,
                            message.type,
                            false,
                            true,
                            new {response = response});
                    #endregion
                }
                else if (message.type == Message.Type.ClientServer.Login.checkHash)
                {
                    #region CHECK_HASH

                    PasswordBank.Response response;
                    byte[] hash = Convert.FromBase64String((string) message.message.hash);

                        response = passwordNode.passwordBank.VerifyLogin((string) message.message.username, hash);

                    int id;

                        passwordNode.passwordBank.GetID((string)message.message.username, out id);

                    returnMessage = new Message(
                        passwordNode.Id,
                        message.senderID,
                        message.traceNumber,
                        message.type,
                        response == PasswordBank.Response.SUCCES,
                        true,
                        new
                        {
                            response = response,
                            userid = id,
                            username = message.message.username
                        });

                    #endregion
                }
                else if (message.type == Message.Type.ClientServer.Login.createUser)
                {
                    #region CREATE_USER

                    byte[] saltBytes;
                    int id;
                    PasswordBank.Response response = passwordNode.passwordBank.CreateUser((string)message.message.username, out saltBytes, out id);

                    if (response == PasswordBank.Response.SUCCES)
                        returnMessage = new Message(
                            passwordNode.Id,
                            message.senderID,
                            message.traceNumber,
                            message.type,
                            true,
                            true,
                            new
                            {
                                salt = Convert.ToBase64String(saltBytes),
                                username = (string)message.message.username,
                                userid = id
                            });
                    else
                        returnMessage = new Message(
                            passwordNode.Id,
                            message.senderID,
                            message.traceNumber,
                            message.type,
                            false,
                            true,
                            new {response = response});
                    #endregion
                }
                else if (message.type == Message.Type.ClientServer.Login.setHash)
                {
                    #region SET_HASH

                    PasswordBank.Response response;
                    byte[] hash = Convert.FromBase64String((string)message.message.hash);

                        response = passwordNode.passwordBank.VerifyUser((string) message.message.username, hash);

                    int id;

                        passwordNode.passwordBank.GetID((string)message.message.username, out id);


                    returnMessage = new Message(
                        passwordNode.Id,
                        message.senderID,
                        message.traceNumber,
                        message.type,
                        response == PasswordBank.Response.SUCCES,
                        true,
                        new
                        {
                            response = response,
                            userid = id,
                            username = message.message.username
                        });

                    #endregion
                }
                else
                    return NodeResponse.messageTypeMismatch;
            }
            PostBox.Response pbResponse = PostBox.instance.PostMessage(returnMessage);
            if (pbResponse == PostBox.Response.SUCCESS) return NodeResponse.succes;
            return NodeResponse.PostBox.unableToSendMessage;
        }
    }
}
