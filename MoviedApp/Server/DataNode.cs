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

        private bool UserExists(UserID user)
        {
            return userEntries.ContainsKey(user);
        }

        private bool UserHasMovie(UserID user, int movieId)
        {
            return UserExists(user) && userEntries[user].checkIns.Any(checkIn => checkIn.movieId == movieId);
        }

        private static ID<NodeResponse> MessageHandler(Node node, Message message)
        {
            if (node.GetType() != typeof(DataNode))
                return Node.NodeResponse.PreCheck.nodeMismatch;

            if (message.type.isa(Message.Type.userData) == false)
                return NodeResponse.messageTypeMismatch;

            Message returnMessage;

            UserID userid = (int)message.message.userid;
            CheckIn checkIn = new CheckIn((JObject)message.message.checkIn);

            if (message.type == Message.Type.UserData.CheckIn.create)
            {
                #region create
                if (instance.UserExists(userid) == false) instance.userEntries.Add(userid, new UserEntry());
                bool checkInExists = false;
                if (instance.UserExists(userid))
                    checkInExists = instance.userEntries
                        .Single(pair => pair.Key == userid).Value.checkIns
                        .Contains(checkIn);


                returnMessage = new Message
                {
                    destinationID = message.senderID,
                    senderID = node.Id,
                    traceNumber = message.traceNumber,
                    type = message.type,
                    isResponse = true,
                    succes = instance.UserExists(userid) ? !checkInExists : true
                };  

                if (checkInExists == false)
                    instance.userEntries[userid].checkIns.Add(checkIn);
#endregion
            }
            else if (message.type == Message.Type.UserData.CheckIn.modify)
            {
                #region modify
                if (instance.UserExists(userid) == false || instance.UserHasMovie(userid, checkIn.movieId) == false)
                    returnMessage = new Message
                    {
                        destinationID = message.senderID,
                        senderID = node.Id,
                        traceNumber = message.traceNumber,
                        type = message.type,
                        isResponse = true,
                        succes = false
                    };
                else
                {
                    CheckIn storedCheckIn = instance.userEntries[userid].checkIns.Find(_checkIn => _checkIn.movieId == checkIn.movieId);
                    storedCheckIn.rating = checkIn.rating;
                    storedCheckIn.description = checkIn.description;
                    returnMessage = new Message
                    {
                        destinationID = message.senderID,
                        senderID = node.Id,
                        traceNumber = message.traceNumber,
                        isResponse = true,
                        succes = true
                    };
                }
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
                    message = checkIns.Serialize()
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
