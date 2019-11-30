using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.one
{
    public class FileLogger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}
