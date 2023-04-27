using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton
{
    public class ExceptionHandler
    {
        private static ExceptionHandler _eh;
        private static StreamWriter _sw;
        private static object _obj = new object();


        public ExceptionHandler()
        {
            _sw = new StreamWriter(@"C:\Error.txt");
        }


        public static ExceptionHandler GetInstance
        {
            get{

                lock (_obj)
                {
                    if (_eh == null)
                        _eh = new ExceptionHandler();
                    return _eh;
                }

            }
        }

        public void WriteLog(string msg)
        {
            _sw.WriteLine(msg);
            _sw.Flush();
        }


    }
}
