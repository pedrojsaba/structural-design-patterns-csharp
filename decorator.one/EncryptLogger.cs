using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.one
{
    public class EncryptLogger : LoggerDecorator
    {
        public EncryptLogger(ILogger logger) : base(logger)
        {
        }

        public void log(String dataLine)
        {
            dataLine = encrypt(dataLine);
            logger.log(dataLine);
        }

        public String encrypt(String dataLine)
        {
            dataLine = dataLine.Substring(dataLine.Length - 1) + dataLine.Substring(0, dataLine.Length - 1);
            return dataLine;
        }

    }
}
