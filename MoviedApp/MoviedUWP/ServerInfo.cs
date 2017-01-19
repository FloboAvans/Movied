using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Chilkat;
using Shared_Code_Portable;
using Shared_Code_Portable.ClientSide;

namespace MoviedUWP
{
    static class ServerInfo
    {
        public static bool hasConnected = false;
        private static bool hasInited = false;
        public static int userid = -1;

        public static void Init(Action OnConnected)
        {
            if (hasInited) return;
            hasInited = true;
            ServerHandler.instance.OnHandshakeComplete += () => { hasConnected = true;
                OnConnected();
            };
            UniqeRandomNumber.makeRandom = i => CryptographicBuffer.GenerateRandom((uint) i).ToArray();
        }

        /// <summary>
        /// generates a password hash
        /// </summary>
        /// <param name="pasword"></param>
        /// <param name="salt"></param>
        /// <returns>the password hash</returns>
        public static byte[] HashPasword(string pasword, byte[] salt)
        {
            byte[] hashInput = new byte[pasword.Length + salt.Length]; // allocates an array to combine the password and the salt
            Array.Copy(Encoding.UTF8.GetBytes(pasword), 0, hashInput, 0, pasword.Length); // adds the password
            Array.Copy(salt, 0, hashInput, pasword.Length, salt.Length); // adds the salt

            var input = CryptographicBuffer.CreateFromByteArray(hashInput);
            var hasher = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha512);
            return hasher.HashData(input).ToArray();

            /*Crypt2 crypt = new Crypt2();
            crypt.HashAlgorithm = "sha512";
            crypt.EncodingMode = "base64";
            return crypt.HashStringENC(Convert.ToBase64String(hashInput));*/
            //return new SHA512CryptoServiceProvider().ComputeHash(hashInput); // generates the hash
        }

        public enum Response
        {
            SUCCES,
            UNKNOWN_FAILURE,
            NO_SUCH_USER,
            USER_EXISTS,
            USER_IS_NOT_VALIDATED,
            USER_IS_VALIDATED,
            HASH_MISMATCH
        }
    }
}
