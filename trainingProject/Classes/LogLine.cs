using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    class LogLine
    {
        public static string Message(string logLine)
        {
            int index = logLine.IndexOf(":");
            if (index >= 0)
                logLine = logLine.Substring(index + 2);
            return logLine.Trim();
        }

        public static string LogLevel(string logline)
        {
            if (logline.Contains("ERROR"))
                return "error";
            else
            {
                if (logline.Contains("WARNING"))
                    return "warning";
                else
                    return "info";
            }
        }

        public static string Reformat(string logline)
            
        {
            return $"{Message(logline)} ({LogLevel(logline)})";
        }
    }
}
