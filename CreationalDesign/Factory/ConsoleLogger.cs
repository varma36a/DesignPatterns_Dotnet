using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine(error);
        }
    }
}
