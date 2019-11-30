using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.one
{
    public class ConsoleLogger : ILogger
    {
        void ILogger.log(string message)
        {
            Console.WriteLine("Console: " + message);
        }
    }
}
