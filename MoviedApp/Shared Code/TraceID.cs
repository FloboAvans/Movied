using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared_Code { 

    [StructLayout(LayoutKind.Explicit, Size = sizeof(ulong)*2)]
    public  struct TraceID
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int memcmp(byte[] b1, byte[] b2, long count);

        [FieldOffset(0)] private UniqeRandomNumber generatorID;
        [FieldOffset(sizeof(ulong))] private UniqeRandomNumber traceId;

        public static UniqeRandomNumber localID;

        public static readonly TraceID None = default(TraceID);

        public static TraceID GenerateTraceID()
        {
            return new TraceID {generatorID = localID, traceId = UniqeRandomNumber.Generate()};
        }

        public static unsafe implicit operator byte[](TraceID id)
        {
            byte[] outBytes = new byte[sizeof(TraceID)];

            byte* pTraceID = (byte*)&id;
            Marshal.Copy((IntPtr)pTraceID, outBytes, 0, sizeof(ulong)*2);

            return outBytes;
        }

        public static unsafe implicit operator TraceID(byte[] id)
        {
            TraceID traceId;

            byte* pTraceID = (byte*) &traceId;
            fixed (byte* pId = id)
            {
                byte* pId8 = &pId[8];
                byte* pTraceId8 = &pTraceID[8];

                *(ulong*)pTraceID = *(ulong*)pId;
                *(ulong*) pTraceId8 = *(ulong*) pId8;
            }

            return traceId;
        }

        public static bool operator ==(TraceID id1, TraceID id2)
        {
            return memcmp(id1, id2, sizeof(ulong)*2) == 0;
        }

        public static bool operator !=(TraceID id1, TraceID id2)
        {
            return !(id1 == id2);
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = sizeof(ulong))]
    public unsafe struct UniqeRandomNumber
    {
        [FieldOffset(0)]
        private fixed byte count[3];
        [FieldOffset(3)]
        private fixed byte random[5];

        private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        private static uint Count = 0;

        public static UniqeRandomNumber Generate()
        {
            UniqeRandomNumber number;

            byte[] countBytes = BitConverter.GetBytes(Count++);
            byte[] randomBytes = new byte[5];
            rng.GetBytes(randomBytes);

            fixed (byte* pCountBytes = countBytes, pRandomBytes = randomBytes)
            {
                byte* pCount = number.count, pRandom = number.random;

                for (int i = 0; i < 3; i++)
                    pCount[i] = pCountBytes[i + 1];

                for (int i = 0; i < 5; i++)
                    pRandom[i] = pRandomBytes[i];
            }

            return number;
        }
    }
}
