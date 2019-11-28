using Bridge.One;

public class TextMessage : IMessage
{
    private IMessageLogger logger;

    public TextMessage(IMessageLogger logger)
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
        return message;
    }
}

