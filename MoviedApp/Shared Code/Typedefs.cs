using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    public struct MovieID
    {
        private int value;

        public static implicit operator int(MovieID id)
        {
            return id.value;
        }

        public static implicit operator MovieID(int id)
        {
            return new MovieID {value = id};
        }
    }

    public struct Date
    {
        private long value;

        public static implicit operator long(Date date)
        {
            return date.value;
        }

        public static implicit operator Date(long date)
        {
            return new Date {value = date};
        }
    }

    public struct UserID
    {
        private int value;

        public static implicit operator int(UserID id)
        {
            return id.value;
        }

        public static implicit operator UserID(int id)
        {
            return new UserID {value = id};
        }
    }
}
