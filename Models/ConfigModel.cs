using System;
using Task3_1.Enums;

namespace Task3_1.Models
{
    public class ConfigModel
    {
        public ConfigModel()
        {
            Url = string.Empty;
            BrowserArguments = new string[] { };
        }

        public string Url { get; set; }
        public TimeSpan WaitTime { get; set; }
        public TimeSpan PageLoadWait { get; set; }
        public Browsers Browser { get; set; }
        public string[] BrowserArguments { get; set; }
    }
}