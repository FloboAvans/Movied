using System;
using Newtonsoft.Json.Linq;

namespace Shared_Code_Portable
{
    // http://stackoverflow.com/questions/980766/how-do-i-declare-a-nested-enum (01/11/2016)
    // author: yoyo

    public struct ID<T> 
    {
        public static ID<T> none;

        public ID<T> this[int childID]
        {
            get { return new ID<T>((mID << 8) | (uint)childID); }
        }

        public ID(JObject jObject)
        {
            mID = (uint) jObject["mID"];
        }

        public JToken Serialize()
        {
            JObject jObject = new JObject();
            jObject.Add("mID", mID);
            return jObject;
        }

        public ID<T> super
        {
            get { return new ID<T>(mID >> 8); }
        }

        public bool isa(ID<T> super)
        {
            return (this != none) && ((this.super == super) || this.super.isa(super));
        }

        public static implicit operator ID<T>(int id)
        {
            if (id == 0)
            {
                throw new System.InvalidCastException("top level id cannot be 0");
            }
            return new ID<T>((uint)id);
        }

        public static bool operator ==(ID<T> a, ID<T> b)
        {
            return a.mID == b.mID;
        }

        public static bool operator !=(ID<T> a, ID<T> b)
        {
            return a.mID != b.mID;
        }

        public override bool Equals(object obj)
        {
            if (obj is ID<T>)
                return ((ID<T>)obj).mID == mID;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (int)mID;
        }

        private ID(uint id)
        {
            mID = id;
        }

        public static implicit operator uint(ID<T> id)
        {
            return id.mID;
        }

        public readonly uint mID;

        public override string ToString()
        {
            return ToStringer(this);
        }

        public static Func<ID<T>, string> ToStringer = (arg1) => "toString not suported";
    }
}
