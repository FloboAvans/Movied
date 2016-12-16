using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    public struct MovieID
    {
        public int value;

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
        public long value;

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
        public int value;

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
