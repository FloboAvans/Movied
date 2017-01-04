using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Shared_Code
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

        public JObject Serialize()
        {
            // TODO finsish this
            //JToken
            return null;
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
            return this.ToString<T, T>();
        }
    }

    public static class IDExtensions
    {
        public static string ToString<T,G>(this ID<G> id)
        {
            return ToString(id, typeof(T));
        }

        public static string ToString<G>(this ID<G> id, Type type)
        {
            foreach (var field in type.GetFields(BindingFlags.GetField | BindingFlags.Public | BindingFlags.Static))
            {
                if ((field.FieldType == typeof(ID<G>)) && id.Equals(field.GetValue(null)))
                {
                    return string.Format("{0}.{1}", type.ToString().Replace('+', '.'), field.Name);
                }
            }

            foreach (var nestedType in type.GetNestedTypes())
            {
                string asNestedType = ToString<G>(id, nestedType);
                if (asNestedType != null)
                {
                    return asNestedType;
                }
            }

            return null;
        }
    }
}
