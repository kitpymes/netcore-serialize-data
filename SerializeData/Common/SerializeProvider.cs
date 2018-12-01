using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeData
{
    public static class SerializeProvider
    {
        public static void Serialize(string filePath, object data)
        {
            if (data is null)
                throw new Exception("El párametro: " + nameof(data) + " es nulo");

            var bin = new BinaryFormatter();

            using (var stream = File.Open(filePath, File.Exists(filePath) ? FileMode.Open : FileMode.Create))
            {
                bin.Serialize(stream, data);
            }
        }

        public static object Deserialize(string filePath)
        {
            if (!File.Exists(filePath))
                throw new Exception("El archivo: " + nameof(filePath) + " no existe");

            object data = default;
            var bin = new BinaryFormatter();

            using (var stream = File.Open(filePath, FileMode.Open))
            {
                data = bin.Deserialize(stream);
            }

            return data;
        }
    }
}