using Newtonsoft.Json;
using System;

namespace SerializeData
{
    public static class TemplateNetCore
    {
        public static void Start()
        {
            var baseFilePath = AppContext.BaseDirectory.Split("bin")[0] + $@"{nameof(TemplateNetCore)}\";
            var readFilePath = baseFilePath + "config.json";
            var writeFilePath = baseFilePath + "config.dat";

            Helper.SerializeEncrypt(readFilePath, writeFilePath);
            var data = Helper.DeserializeDecrypt(writeFilePath);

            var jsonConfig = JsonConvert.DeserializeObject<JsonConfig>(data);
            //Console.WriteLine(jsonConfig.DefaultCompanyName);

            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
