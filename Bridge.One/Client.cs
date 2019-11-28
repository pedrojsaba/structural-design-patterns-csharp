using System;

namespace Bridge.One
{
    class Client
    {
        static void Main(string[] args)
        {
            IMessageLogger logger = new FileLogger();
            IMessage message = new EncryptedMessage(logger);
            message.Log("Test Message");

            Console.WriteLine("*************************************************************");
            logger = new ConsoleLogger();
            message = new TextMessage(logger);
            message.Log("Test Message");

            Console.ReadLine();
        }
    }
}
