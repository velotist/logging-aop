using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingSystem
{
    class LoggingBase
    {
        protected Logger log;

        public LoggingBase(Logger loggerInstance)
        {
            this.log = loggerInstance;
        }
    }
}
