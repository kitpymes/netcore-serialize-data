using System;
using System.IO;

namespace SerializeData
{
    public class Helper
    {
        public static void SerializeEncrypt(string readFilePath, string writeFilePath)
        {
            if (!File.Exists(readFilePath))
                throw new Exception($"El archivo: {nameof(readFilePath)} no existe.");

            var data = File.ReadAllText(readFilePath);
            var encrypt = EncryptionProvider.Encrypt(data);
            SerializeProvider.Serialize(writeFilePath, encrypt);
        }

        public static string DeserializeDecrypt(string writeFilePath)
        {
            if (!File.Exists(writeFilePath))
                throw new Exception($"El archivo: {nameof(writeFilePath)} no existe.");

            var deserialize = SerializeProvider.Deserialize(writeFilePath);

            return EncryptionProvider.Decrypt(deserialize.ToString());
        }
    }
}
