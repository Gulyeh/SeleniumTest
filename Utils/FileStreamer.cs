using Newtonsoft.Json;
using System.IO;

namespace Task3_1.Utils
{
    public class FileStreamer
    {
        public static T? DeserializeFileToObject<T>(string path)
        {
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}