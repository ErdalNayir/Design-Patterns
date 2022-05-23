using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Logger
    {
        private static Logger logger;
        private static Object _lockObject = new object();

        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if(logger == null)
            {
                lock (_lockObject)
                {
                    if (logger == null)
                    {
                        logger = new Logger();
                    }
                }
                
            }
            return logger;

        }

 
    }
}
