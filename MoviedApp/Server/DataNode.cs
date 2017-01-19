using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (message.type.isa(Message.Type.ClientServer.User.checkIn) == false)
                return NodeResponse.messageTypeMismatch;

            UserID userid = (int)message.message.userid;

            if (message.type == Message.Type.ClientServer.User.CheckIn.create)
            {
                bool exists = instance.userEntries.ContainsKey(userid);
                if (exists)
                {
                    bool hasCheckedIn = (instance.userEntries
                                .Single(pair => pair.Key == userid)
                        ).Value.checkIns
                        .Contains(message.message.checkIn);


                }
            }

            return default(ID<NodeResponse>);
        }
    }

    
}
