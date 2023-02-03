using System;
using Task3_1.Models;

namespace Task3_1.Utils
{
    public static class Config
    {
        public static ConfigModel ConfigData = ReadConfig("Config.json");
        private static ConfigModel ReadConfig(string path)
        {
            var deserialized = FileStreamer.DeserializeFileToObject<ConfigModel>(path);
            return deserialized is not null ? deserialized : throw new Exception("Config was null");
        }
    }
}