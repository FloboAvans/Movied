using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Shared_Code
{
    public struct Coordinate
    {
        public double Latitude, Longitude;
    }

    public struct CheckIn
    {
        /*
        [Flags]
        public enum ContentE : byte
        {
            Rating = 1,
            Description = 2,
            Position = 4,
            Date = 8,
            ModDate = 16
        }
        */
        // TODO possebly use specific layout and therefore consistand size
        //public ContentE Content;
        public int movieId;
        public byte? rating;
        public string description;
        //public Coordinate Position;
        //public long? date, modDate;

        public static long GetCurrentDate()
        {
            return (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        public JObject Serialize()
        {
            JObject jObject = new JObject();
            jObject.Add("movieId", movieId);
            
            return jObject;
        }

        public CheckIn(JObject jObject)
        {
            JToken _out;
            movieId = (int) jObject["movieId"];
            rating = jObject.TryGetValue("rating", out _out) ? (byte?) _out : null;
            description = jObject.TryGetValue("description", out _out) ? (string)_out : null;
        }

        private void test()
        {
            CheckIn checkIn = new CheckIn
            {
                movieId = 123,
                description = "super awesome",
                rating = 10
                //date = GetCurrentDate()
            };
        }
    }
}
