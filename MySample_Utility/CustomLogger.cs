using MySample_Utility.interfaces;
using System;
using NLog;
//using Microsoft.Extensions.Logging;

namespace MySample_Utility
{
    public class CustomLogger : ICustomLogger
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        

        public void LogTrace(string message)
        {
            logger.Info(message);
        }
    }
}
