using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    public class FileLogger : ILogger
    {
        public void LogError(string error)
        {
            File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
