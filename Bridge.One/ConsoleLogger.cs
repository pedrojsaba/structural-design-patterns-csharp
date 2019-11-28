using System;

namespace Bridge.One
{
    public class ConsoleLogger : IMessageLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Console: {0}", message);
        }
    }
}
