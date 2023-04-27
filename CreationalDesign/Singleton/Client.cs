using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Client
    {
        public void Add()
        {
            try
            {
                // TO DO:

            }
            catch (Exception ex)
            {
                // var obj = new ExceptionHandler();
                ExceptionHandler.GetInstance.WriteLog(ex.Message);
            }
        }
    }
}
