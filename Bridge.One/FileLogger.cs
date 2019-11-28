using System;

namespace Bridge.One
{
    public class FileLogger : IMessageLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("File: {0}", message);
        }
    }
}
