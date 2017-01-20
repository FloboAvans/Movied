using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Shared_Code;
using Shared_Code_Portable;

namespace Server
{
    class DataNode : Node
    {
        class UserEntry
        {
            public List<CheckIn> checkIns = new List<CheckIn>();
            //public List<Tuple<MovieID, Date, UserID>> recomendations = new List<Tuple<MovieID, Date, UserID>>();
            public List<Tuple<MovieID, Date>> wishlist = new List<Tuple<MovieID, Date>>();
        }

        public static DataNode instance = new DataNode();

        private DataNode() : base(MessageHandler, Constants.Server.DATA_NODE_ADDRESS)
        {
            
        }

        private Dictionary<UserID, UserEntry> userEntries = new Dictionary<UserID, UserEntry>();

        private static ID<NodeResponse> MessageHandler(Node node, Message message)
        {
            if (node.GetType() != typeof(DataNode))
                return Node.NodeResponse.PreCheck.nodeMismatch;

            if (message.type.isa(Message.Type.userData) == false)
                return NodeResponse.messageTypeMismatch;

            Message returnMessage;

            UserID userid = (int)message.message.userid;
            CheckIn checkIn = new CheckIn((JObject) message.message.checkIn);

            if (message.type == Message.Type.UserData.CheckIn.create)
            {
                #region create
                bool userExists = instance.userEntries.ContainsKey(userid);
                if (userExists == false) instance.userEntries.Add(userid, message.message.checkIn);
                bool checkInExists = false;
                if (userExists)
                    checkInExists = instance.userEntries
                        .Single(pair => pair.Key == userid).Value.checkIns
                        .Contains(message.message.checkIn);


                returnMessage = new Message
                {
                    destinationID = message.senderID,
                    senderID = node.Id,
                    traceNumber = message.traceNumber,
                    type = message.type,
                    isResponse = true,
                    succes = userExists ? !checkInExists : true
                };  

                if (checkInExists == false)
                    instance.userEntries[userid].checkIns.Add(checkIn);
#endregion
            }
            else if (message.type == Message.Type.UserData.CheckIn.getAll)
            {
                #region getAll
                List<CheckIn> checkIns = null;
                if (instance.userEntries.ContainsKey(userid))
                    checkIns = instance.userEntries[userid].checkIns;

                returnMessage = new Message
                {
                    destinationID = message.senderID,
                    senderID = node.Id,
                    traceNumber = message.traceNumber,
                    type = message.type,
                    isResponse = true,
                    succes = checkIns != null,
                    message = checkIns
                };
                #endregion
            }
            else
            {
                return NodeResponse.messageTypeMismatch;
            }

            PostBox.Response pbResponse = PostBox.instance.PostMessage(returnMessage);
            if (pbResponse == PostBox.Response.SUCCESS) return NodeResponse.succes;
            return NodeResponse.PostBox.unableToSendMessage;
        }
    }

    
}
