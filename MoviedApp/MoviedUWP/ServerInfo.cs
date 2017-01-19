using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Shared_Code_Portable;
using Shared_Code_Portable.ClientSide;

namespace MoviedUWP
{
    static class ServerInfo
    {
        public static bool hasConnected = false;
        private static bool hasInited = false;

        public static void Init()
        {
            if (hasInited) return;
            hasInited = true;
            ServerHandler.instance.OnHandshakeComplete += () => hasConnected = true;
            UniqeRandomNumber.makeRandom = i => CryptographicBuffer.GenerateRandom((uint) i).ToArray();
        }
    }
}
