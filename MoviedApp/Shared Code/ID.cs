using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    // http://stackoverflow.com/questions/980766/how-do-i-declare-a-nested-enum (01/11/2016)
    // author: yoyo

    [Serializable]
    public struct ID<T> : ISerializable
    {
        public static ID<T> none;

        public ID<T> this[int childID]
        {
            get { return new ID<T>((mID << 8) | (uint)childID); }
        }

        public ID(SerializationInfo info, StreamingContext context)
        {
            mID = info.GetUInt32("mID");
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("mID", mID);
        }

        private ID(uint id)
        {
            mID = id;
        }

        public static implicit operator uint(ID<T> id)
        {
            return id.mID;
        }

        private readonly uint mID;

        public override string ToString()
        {
            Type type = typeof(T);
            foreach (var field in type.GetFields(BindingFlags.GetField | BindingFlags.Public | BindingFlags.Static))
            {
                if ((field.FieldType == typeof(ID<T>)) && this.Equals(field.GetValue(null)))
                {
                    return string.Format("{0}.{1}", type.ToString().Replace('+', '.'), field.Name);
                }
            }

            foreach (var nestedType in type.GetNestedTypes())
            {
                string asNestedType = nestedType.ToString();
                if (asNestedType != null)
                {
                    return asNestedType;
                }
            }

            return null;
        }
    }
}
