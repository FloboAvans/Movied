using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    public struct Coordinate
    {
        public double Latitude, Longitude;
    }

    public struct CheckIn
    {
        [Flags]
        public enum ContentE : byte
        {
            Rating = 1,
            Description = 2,
            Position = 4,
            Date = 8,
            ModDate = 16
        }

        // TODO possebly use specific layout and therefore consistand size
        public ContentE Content;
        public int movieId;
        public byte rating;
        public string description;
        public Coordinate Position;
        public long date, modDate;

        public static long GetCurrentDate()
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        private void test()
        {
            CheckIn checkIn = new CheckIn
            {
                Content = ContentE.Description | ContentE.Date,
                description = "super awesome",
                date = CheckIn.GetCurrentDate()
            };
        }
    }
}
