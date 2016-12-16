using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    struct CheckIn
    {
        // TODO possebly use specific layout and therefore consistand size
        public int movieId;
        public byte rating;
        public string description;
        // TODO add position
        public long date, modDate;

        public static long GetCurrentDate()
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
    }
}
