using System;
using Shared_Code;

namespace Shared_Code_Portable
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

            public static readonly NodeAddress SERVER_NODE_ADDRESS = new UniqeRandomNumber(new byte[3] {0,0,0}, new byte[5] {1,2,3,4,5});
        }

        public static class Server
        {
            public static readonly NodeAddress PASSWORD_NODE_ADDRESS = new UniqeRandomNumber(new byte[3] {0, 0, 0}, new byte[5] {5, 4, 3, 2, 1});
        }

        public static class GeneralInfo
        {
            public static readonly byte[] VERSION_BYTES = { 0, 1, 0, 0 };
            public static readonly uint VERSION = BitConverter.ToUInt32(VERSION_BYTES, 0);
        }
    }
}
