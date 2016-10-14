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
        /// used to store the salt and hash for a particular user(implicit)
        /// </summary>
        [Serializable]
        private class Entry : ISerializable
        {
            const int SALT_LENGTH = 64; // the salt size in bytes, equal to the output size of the SHA512

            public byte[] salt; // the salt used for the hash. salt cannot be null
                                // (salt is used to make te generation of a rainbow-table imposible. However a lookup table can still be generated for this specific entry)
            public byte[] hash; // the hash of the password + salt. hash may be null

            public bool IsVerievied { get { return hash != null; } } // checks if the entry has been verified (a.k.a. has a hash)

            /// <summary>
            /// generates and stores the salt for the entry
            /// </summary>
            /// 
            public Entry()
            {
                salt = new byte[SALT_LENGTH]; // allocate an array for the salt
                rng.GetBytes(salt); // generates the salt
                hash = null; // explicitly sets the hash to null
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

        // stores all the users and their entry
        private Dictionary<string, Entry> users = new Dictionary<string, Entry>();

        /// <summary>
        /// generates the initial PasswordBank
        /// </summary>
        /// <param name="adminPassword"></param>
        public PasswordBank(string adminPassword)
        {
            byte[] salt;
            CreateUser("admin", out salt);
            VerifyUser("admin", HashPasword(adminPassword, salt));
        }

        /// <summary>
        /// reconstructs an passwordBank from serializable form
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public PasswordBank(SerializationInfo info, StreamingContext context)
        {
            users = (Dictionary<string, Entry>) info.GetValue("users", users.GetType());
        }

        /// <summary>
        /// prepares an passwordBank for serialization
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("users", users);
        }

        /// <summary>
        /// returns a boolean indicating wether the users exists or not
        /// </summary>
        /// <param name="user">the username that needs to be checked</param>
        /// <returns></returns>
        public bool UserExists(string user)
        {
            return users.ContainsKey(user);
        }

        /// <summary>
        /// creates a user and outputs the entry's salt
        /// </summary>
        /// <param name="user">the username</param>
        /// <param name="salt">the salt to be used for hashing</param>
        /// <returns>succes</returns>
        public Response CreateUser(string user, out byte[] salt)
        {
            if (users.ContainsKey(user)) // if the user already exists
            {
                salt = null; // set the salt to null
                return Response.USER_EXISTS; // and return
            }

            Entry userEntry = new Entry(); // construct a new entry
            salt = userEntry.salt; // extract the salt
            users.Add(user, userEntry); // add the user to the dictionary
            return Response.SUCCES; // and return
        }

        /// <summary>
        /// adds the hash to the user and completes the setup
        /// </summary>
        /// <param name="user"></param>
        /// <param name="hash"></param>
        /// <returns>succes</returns>
        public Response VerifyUser(string user, byte[] hash)
        {
            Entry e;
            if (users.TryGetValue(user, out e) == false) // if the user doesn't exist
                return Response.NO_SUCH_USER; // exit
            if (e.IsVerievied) // if the user is verified already
                return Response.USER_IS_VALIDATED; // return 
            e.hash = hash; // otherwise we can set the hash
            return Response.SUCCES; // and we return succes
        }

        /// <summary>
        /// checks if a login is succesfull
        /// </summary>
        /// <param name="user"></param>
        /// <param name="hash"></param>
        /// <returns>succes</returns>
        public Response VerifyLogin(string user, byte[] hash)
        {
            Entry e;
            if (users.TryGetValue(user, out e) == false) // if the user doesn't exist
                return Response.NO_SUCH_USER;// we exit
            if (e.IsVerievied == false) // if the user isn't verified
                return Response.USER_IS_NOT_VALIDATED; // we return (we cannot compare the hash)
            return Enumerable.SequenceEqual(hash, e.hash) ? Response.SUCCES : Response.HASH_MISMATCH; // otherwise we return the result of comparing the two hashes
        }

        /// <summary>
        /// outputs the salt for a specific user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="salt"></param>
        /// <returns>succes</returns>
        public Response GetSalt(string user, out byte[] salt)
        {
            Entry e;
            if (users.TryGetValue(user, out e) == false) // if the user doesn't exist
            {
                salt = null; // set the salt 
                return Response.NO_SUCH_USER; // and return
            }
            salt = e.salt; // otherwise set the salt
            return Response.SUCCES; // and return succes
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
