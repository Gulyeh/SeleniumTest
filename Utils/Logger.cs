using System;

namespace Task3_1.Utils
{
    public static class Logger
    {
        public static void Info(string message) => Console.WriteLine($"[{DateTime.Now}](Info) - {message}");
        public static void Debug(string message) => Console.WriteLine($"[{DateTime.Now}](Debug) - {message}");
        public static void Warn(string message) => Console.WriteLine($"[{DateTime.Now}](Warn) - {message}");
        public static void Error(string message) => Console.WriteLine($"[{DateTime.Now}](Error) - {message}");
    }
}