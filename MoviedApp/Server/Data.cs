using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Code;

namespace Server
{
    class UserEntry
    {
        public List<CheckIn> checkIns = new List<CheckIn>();
        public List<Tuple<MovieID, Date, UserID>> recomendations = new List<Tuple<MovieID, Date, UserID>>();
        public List<Tuple<MovieID, Date>> wishlist = new List<Tuple<MovieID, Date>>();
    }

    class Data
    {
        public static Dictionary<UserID, UserEntry> UserEntries = new Dictionary<UserID, UserEntry>();
    }
}
