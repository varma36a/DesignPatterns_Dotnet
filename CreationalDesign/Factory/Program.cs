using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LoggerFactory.CreateLogger(LoggerType.Console);
            Client client = new Client(logger);
            client.Add();
        }
    }
}
