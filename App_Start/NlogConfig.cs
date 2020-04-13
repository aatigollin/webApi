using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.App_Start
{
    public static class NlogConfig
    {
        public static void Register()
        {

            //var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            //var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "${basedir}/logs/${shortdate}.log" } ;
            //logfile.Layout = "${longdate} ${uppercase:${level}} ${message}";
            
            // Rules for mapping loggers to targets            
            //config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            // Apply config           
            //NLog.LogManager.Configuration = config;
        }
    }
}