using System;

namespace decorator.one
{
    public class HTMLLogger : LoggerDecorator
    {    
        public HTMLLogger(ILogger logger) : base(logger)
        {
        }

        public void log(string dataLine)
        {
            dataLine = makeHTML(dataLine);
            this.logger.log(dataLine);
        }

        public String makeHTML(String dataLine)
        {
            dataLine = "<HTML><BODY>" + "<b>" + dataLine + "</b>" + "</BODY></HTML>";
            return dataLine;
        }
    }
}
