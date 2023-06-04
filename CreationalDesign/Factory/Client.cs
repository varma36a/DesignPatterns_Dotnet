using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Client
    {
        ILogger _logger;
        public Client(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            try
            {
                // TO DO:
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}
