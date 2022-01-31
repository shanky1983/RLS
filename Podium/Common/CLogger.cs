using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;

namespace Attune.Podium.Common
{
    public enum ELogLevel
    {
        DEBUG = 1,
        ERROR,
        FATAL,
        INFO,
        WARN
    }


    public static class CLogger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CLogger));
        

        /// <summary>
        /// Public static constructor that does one time type level initialisation
        /// </summary>
        static CLogger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void LogWarning(string str, Exception excp)
        {
            log.Warn(str, excp);
        }

        public static void LogWarning(string str)
        {
            log.Warn(str);
        }

        public static void LogError(string str, Exception excp)
        {
            log.Error(str, excp);
        }

        public static void LogFatal(string str, Exception excp)
        {
            log.Fatal(str, excp);
        }

        public static void LogInfo(string str)
        {
            log.Info(str);
        }

        public static void LogInfo(string str, Exception excp)
        {
            log.Info(str, excp);
        }
            

    }
}

