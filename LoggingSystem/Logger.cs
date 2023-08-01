using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;

namespace LoggingSystem
{
    class Logger
    {
        private ILog log;

        public ILog Log
        {
            get { return log; }
        }

        public Logger()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo("log4net.config"));
            this.log = log4net.LogManager.GetLogger("AutoLogger");
        }
    }
}
