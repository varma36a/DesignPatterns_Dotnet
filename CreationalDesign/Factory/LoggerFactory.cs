using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger(LoggerType type)
        {
            switch (type)
            {
                case LoggerType.File:
                    return new FileLogger();
                case LoggerType.Console:
                default:
                    return new ConsoleLogger();
            }
        }
    }
}
