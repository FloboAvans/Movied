using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Runtime.Serialization;

namespace HashingTest
{
    /// <summary>
    /// used to manage passwords by: storing passwords, generating salt, generating the hash, and check login requests
    /// </summary>
    [Serializable]
    public class PasswordBank : ISerializable
    {
        /// <summary>
        /// used to store the salt and hash for a particular userName(implicit)
        /// </summary>
        [Serializable]
        private class Entry : ISerializable
        {
            const int SALT_LENGTH = 64; // the salt size in bytes, equal to the output size of the SHA512

            public byte[] salt; // the salt used for the hash. salt cannot be null
                                // (salt is used to make te generation of a rainbow-table imposible. However a lookup table can still be generated for this specific entry)
            public byte[] hash; // the hash of the password + salt. hash may be null

            public int id;
            public string name;

            public bool IsVerievied { get { return hash != null; } } // checks if the entry has been verified (a.k.a. has a hash)

            /// <summary>
            /// generates and stores the salt for the entry
            /// </summary>
            /// 
            public Entry(Func<int, bool> validID)
            {
                salt = new byte[SALT_LENGTH]; // allocate an array for the salt
                rng.GetBytes(salt); // generates the salt
                hash = null; // explicitly sets the hash to null

                do
                {
                    byte[] idBuff = new byte[4];
                    rng.GetBytes(idBuff);
                    id = BitConverter.ToInt32(idBuff, 0);
                    id = Math.Abs(id) | 1; // ensures id is always uneven
                } while (validID(id) == false);
            }

            /// <summary>
            /// reconstructs an entry from it's serialized form
            /// </summary>
            /// <param name="info"></param>
            /// <param name="context"></param>
            public Entry(SerializationInfo info, StreamingContext context)
            {
                salt = Convert.FromBase64String(info.GetString("salt"));
                // gets the salt and if it doesn't exist sets it to null
                try { hash = Convert.FromBase64String(info.GetString("hash")); } catch (Exception) { hash = null; }
                id = info.GetInt32("id");
                name = info.GetString("name");
            }

            /// <summary>
            /// deconstructs the entry to allow serialisation
            /// </summary>
            /// <param name="info"></param>
            /// <param name="context"></param>
            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("salt", Convert.ToBase64String(salt));
                if (hash != null) info.AddValue("hash", Convert.ToBase64String(hash));
                info.AddValue("id", id);
                info.AddValue("name", name);
            }
        }

        // an enum indicating wether the method call was succesfull
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

        // used to generate the salt
        private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        // stores all the usersName and their entry
        private Dictionary<string, Entry> usersName = new Dictionary<string, Entry>();
        private Dictionary<int, Entry> usersID = new Dictionary<int, Entry>();

        /// <summary>
        /// generates the initial PasswordBank
        /// </summary>
        /// <param name="adminPassword"></param>
        public PasswordBank(string adminPassword)
        {
            byte[] salt;
            int id;
            CreateUser("admin", out salt, out id);
            VerifyUser("admin", HashPasword(adminPassword, salt));
        }

        /// <summary>
        /// reconstructs an passwordBank from serializable form
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public PasswordBank(SerializationInfo info, StreamingContext context)
        {
            usersName = (Dictionary<string, Entry>) info.GetValue("usersName", usersName.GetType());
            usersID = (Dictionary<int, Entry>) info.GetValue("usersID", usersID.GetType());
        }

        /// <summary>
        /// prepares an passwordBank for serialization
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("usersName", usersName);
            info.AddValue("usersID", usersID);
        }

        /// <summary>
        /// returns a boolean indicating wether the usersName exists or not
        /// </summary>
        /// <param name="userName">the username that needs to be checked</param>
        /// <returns></returns>
        public bool UserExists(string userName)
        {
            return usersName.ContainsKey(userName);
        }

        public bool UserExist(int userID)
        {
            return usersID.ContainsKey(userID);
        }

        /// <summary>
        /// creates a user and outputs the entry's salt
        /// </summary>
        /// <param name="userName">the username</param>
        /// <param name="salt">the salt to be used for hashing</param>
        /// <returns>succes</returns>
        public Response CreateUser(string userName, out byte[] salt, out int id)
        {
            if (usersName.ContainsKey(userName)) // if the userName already exists
            {
                salt = null; // set the salt to null
                id = int.MinValue;
                return Response.USER_EXISTS; // and return
            }

            Entry userEntry = new Entry(i => true); // construct a new entry
            salt = userEntry.salt; // extract the salt
            id = userEntry.id; // and the id
            usersName.Add(userName, userEntry); // add the userName to the dictionaries
            usersID.Add(id, userEntry);
            return Response.SUCCES; // and return
        }

        /// <summary>
        /// adds the hash to the user and completes the setup, slower than VerifyUser(int, byte[])
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="hash"></param>
        /// <returns>succes</returns>
        public Response VerifyUser(string userName, byte[] hash)
        {
            // NOTE: we call the VerifyUser(int, byte[]) even though it is slower because it prevents code duplication
            Entry e;
            if (usersName.TryGetValue(userName, out e) == false)
                return Response.NO_SUCH_USER;
            return VerifyUser(e.id, hash); 
        }

        /// <summary>
        /// adds the hash to the user and completes the setup, faster than VerifyUser(string, byte[])
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public Response VerifyUser(int userID, byte[] hash)
        {
            Entry e;
            if (usersID.TryGetValue(userID, out e) == false) // if the userID doesn't exist
                return Response.NO_SUCH_USER; // exit
            if (e.IsVerievied) // if the userName is verified already
                return Response.USER_IS_VALIDATED; // return 
            e.hash = hash; // otherwise we can set the hash
            return Response.SUCCES; // and we return succes
        }

        /// <summary>
        /// checks if a login is succesfull, slower than VerifyLogin(int, byte[])
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="hash"></param>
        /// <returns>succes</returns>
        public Response VerifyLogin(string userName, byte[] hash)
        {
            // NOTE: we call the VerifyLogin(int, byte[]) even though it is slower because it prevents code duplication
            Entry e;
            if (usersName.TryGetValue(userName, out e) == false)
                return Response.NO_SUCH_USER;
            return VerifyLogin(e.id, hash);
        }

        /// <summary>
        /// checks if a login is succesfull, faster than VerifyLogin(string, byte[])
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public Response VerifyLogin(int userID, byte[] hash)
        {
            Entry e;
            if (usersID.TryGetValue(userID, out e) == false) // if the user doesn't exist
                return Response.NO_SUCH_USER;// we exit
            if (e.IsVerievied == false) // if the user isn't verified
                return Response.USER_IS_NOT_VALIDATED; // we return (we cannot compare the hash)
            return Enumerable.SequenceEqual(hash, e.hash) ? Response.SUCCES : Response.HASH_MISMATCH; // otherwise we return the result of comparing the two hashes
        }

        /// <summary>
        /// outputs the salt for a specific user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="salt"></param>
        /// <returns>succes</returns>
        public Response GetSalt(string userName, out byte[] salt)
        {
            Entry e;
            if (usersName.TryGetValue(userName, out e) == false) // if the user doesn't exist
            {
                salt = null; // set the salt 
                return Response.NO_SUCH_USER; // and return
            }
            salt = e.salt; // otherwise set the salt
            return Response.SUCCES; // and return succes
        }

        /// <summary>
        /// outputs the salt for a specific user
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public Response GetSalt(int userID, out byte[] salt)
        {
            Entry e;
            if (usersID.TryGetValue(userID, out e) == false) // if the userName doesn't exist
            {
                salt = null; // set the salt 
                return Response.NO_SUCH_USER; // and return
            }
            salt = e.salt; // otherwise set the salt
            return Response.SUCCES; // and return succes
        }

        public Response GetID(string userName, out int id)
        {
            Entry entry;
            if (usersName.TryGetValue(userName, out entry) == false)
            {
                id = 0;
                return Response.NO_SUCH_USER;
            }
            id = entry.id;
            return Response.SUCCES;
        }

        public Response GetName(int id, out string username)
        {
            Entry entry;
            if (usersID.TryGetValue(id, out entry) == false)
            {
                username = null;
                return Response.NO_SUCH_USER;
            }
            username = entry.name;
            return Response.SUCCES;
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
            return new SHA512CryptoServiceProvider().ComputeHash(hashInput); // generates the hash
        }
    }
}
