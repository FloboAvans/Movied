using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    public static class Constants
    {
        public static class Apis
        {
            public static class TheMovieDatabase
            {
                public const string API_KEY = "c84acd026332c3ab0c37200ff32e6f07";
            }
        }

        public static class Network
        {

            public const string HOST_IP = "localhost";
            public const int HOST_PORT = 9696;

            public const int LENGTH_BYTE_SIZE = 4;
            public const int UNKNOWN_ERROR = -1;

            public const byte SERVER_TRACE_ID = 1;
        }

        public static class GeneralInfo
        {
            public static readonly byte[] VERSION_BYTES = { 0, 1, 0, 0 };
            public static readonly uint VERSION = BitConverter.ToUInt32(VERSION_BYTES, 0);
        }
    }
}
