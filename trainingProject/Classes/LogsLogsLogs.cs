using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace trainingProject
{

    static class LogLine
    {
        public enum LogLevel
        {
            Trace,
            Debug,
            Info,
            Warning,
            Error,
            Fatal,
            Unknown
        }

        private static Dictionary<string, LogLevel> logDic = new Dictionary<string, LogLevel>
        {
            {"[TRC]", LogLevel.Trace},
            {"[DBG]", LogLevel.Debug},
            {"[INF]", LogLevel.Info},
            {"[WRN]", LogLevel.Warning},
            {"[ERR]", LogLevel.Error},
            {"[FTL]", LogLevel.Fatal}
        };
          


        public static LogLevel ParseLogLevel(string logLine)
            => logDic.TryGetValue(logLine.Substring(0, 5), out LogLevel value) ? value : LogLevel.Unknown;
            
        public static string OutputForShortLog(LogLevel logLevel, string message)
            =>$"{(int)logLevel}:{message}";
    }
}
