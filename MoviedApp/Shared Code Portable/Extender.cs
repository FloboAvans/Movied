using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Shared_Code;

namespace Shared_Code_Portable
{
    public static class Extender
    {
        public static JObject Serialize(this List<CheckIn> checkIns)
        {
            if (checkIns == null)
                return null;

            JArray jArray = new JArray();
            foreach (CheckIn checkIn in checkIns)
            {
                jArray.Add(checkIn.Serialize());
            }

            JObject jObject = new JObject();
            jObject.Add("checkins", jArray);
            return jObject;
        }

        public static List<CheckIn> DeserializeToCheckIns(this JObject jObject)
        {
            if (jObject == null) return null;
            JArray jArray = (JArray) jObject["checkins"];

            List<CheckIn> checkIns = new List<CheckIn>(jArray.Count);
            foreach (JToken jToken in jArray)
            {
                checkIns.Add(new CheckIn((JObject)jToken));
            }

            return checkIns;
        }
    }
}
