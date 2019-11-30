using System;

namespace decorator.one
{
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                LoggerFactory factory = new LoggerFactory();
                ILogger logger = factory.getLogger();
                HTMLLogger htmlLogger = new HTMLLogger(logger);
                htmlLogger.log("A Message to Log");
                EncryptLogger encryptLogger = new EncryptLogger(logger);
                encryptLogger.log("A Message to Log");
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
            }
        }
    }
}
