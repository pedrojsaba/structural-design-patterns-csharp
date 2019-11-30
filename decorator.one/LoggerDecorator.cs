using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.one
{
    public class LoggerDecorator : ILogger
    {
        protected ILogger logger = null;

        public LoggerDecorator(ILogger logger)
        {
            this.logger = logger;
        }

        public void log(string dataLine)
        {
            logger.log(dataLine);
        }
    }
}
