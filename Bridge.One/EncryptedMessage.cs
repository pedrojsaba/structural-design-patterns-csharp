namespace Bridge.One
{
    public class EncryptedMessage : IMessage
    {
        private IMessageLogger logger;

        public EncryptedMessage(IMessageLogger logger)
        {
            this.logger = logger;
        }
        public void Log(string message)
        {
            message = PreProcess(message);
            logger.LogMessage(message);
        }
        private string PreProcess(string message)
        {
            message = message.Substring(message.Length - 1) + message[0..^1];
            return message;
        }
    }
}
