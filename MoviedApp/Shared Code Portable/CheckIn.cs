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

    public class CheckIn
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
            if (rating.HasValue) jObject.Add("rating", rating.Value);
            if (description != null) jObject.Add("description", description);

            return jObject;
        }

        public CheckIn(JObject jObject)
        {
            if (jObject == null)
            {
                movieId = -1;
                rating = 255;
                description = null;
                return;
            }

            JToken _out;
            movieId = (int) jObject["movieId"];
            rating = jObject.TryGetValue("rating", out _out) ? (byte?) _out : null;
            description = jObject.TryGetValue("description", out _out) ? (string)_out : null;
        }

        public override string ToString()
        {
            string returnValue = "mID = " + movieId;
            if (rating.HasValue) returnValue += ", rating = " + rating.Value;
            if (description != null) returnValue += ", des = " + description;
            return returnValue;
        }

        public static bool operator ==(CheckIn a, CheckIn b)
        {
            return a.movieId == b.movieId;
        }

        public static bool operator !=(CheckIn a, CheckIn b)
        {
            return !(a == b);
        }
    }
}
