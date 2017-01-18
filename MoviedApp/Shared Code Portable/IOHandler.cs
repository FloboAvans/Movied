using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared_Code;

namespace Shared_Code_Portable
{
    public static class IOHandler
    {
        public class ConnectionAbrubtlyLostException : IOException
        {

        }

        public static Message Read(Stream stream)
        {
            byte[] lengthBuffer = new byte[Constants.Network.LENGTH_BYTE_SIZE];
            stream.Read(lengthBuffer, 0, lengthBuffer.Length);
            int lenght = BitConverter.ToInt32(lengthBuffer, 0);
            if (lenght == Constants.Network.UNKNOWN_ERROR)
                throw new ConnectionAbrubtlyLostException();

            byte[] messageBuffer = new byte[lenght];
            stream.Read(messageBuffer, 0, lenght);
            string messageString = Encoding.UTF8.GetString(messageBuffer, 0, messageBuffer.Length);
            Message message = new Message((JObject)JsonConvert.DeserializeObject(messageString));
            return message;
        }

        public static void Write(Stream stream, Message message)
        {
            string messageString = message.Serialize().ToString();
            byte[] messageBytes = Encoding.UTF8.GetBytes(messageString);
            byte[] lengthBuffer = BitConverter.GetBytes(messageBytes.Length);

            stream.Write(lengthBuffer, 0, lengthBuffer.Length);
            stream.Write(messageBytes, 0, messageBytes.Length);
        }
    }
}
