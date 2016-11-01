using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Code
{
    public static class Constants
    {
        public static class Network
        {

            public const string HOST_IP = "localhost";
            public const int HOST_PORT = 9696;

            public const int LENGTH_BYTE_SIZE = 4;
            public const int UNKNOWN_ERROR = -1;
        }

        public static class GeneralInfo
        {
            public static readonly byte[] VERSION_BYTES = { 0, 1, 0, 0 };
            public static readonly uint VERSION = BitConverter.ToUInt32(VERSION_BYTES, 0);
        }
    }
}
