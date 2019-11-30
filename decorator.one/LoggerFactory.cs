using System;
using Common.Util;

namespace decorator.one
{
    public class LoggerFactory
    {

        public bool isFileLoggingEnabled()
        {
            try
            {
                //string fileLoggingValue = Common.Util.getPropertyValue("logger.properties", "FileLogging");
                //return fileLoggingValue.Equals("ON");
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        // Factory Method
        public ILogger getLogger()
        {
            if(isFileLoggingEnabled()) {
                return new FileLogger();
            } else
            {
                return new ConsoleLogger();
            }
        }
    }
}
