using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Reserver
{
    public static class Logger
    {
        private static StreamWriter swLog;
        private const string sLOG_FILE_PATH = "log/log.txt";

        static Logger()
        {
            Logger.OpenLogger();

            /*
            if(!Directory.Exists("Log"))
            {
                Directory.CreateDirectory("Log");
            }
            */
        }

        public static void OpenLogger()
        {
            Logger.swLog = new StreamWriter(sLOG_FILE_PATH, true);
            Logger.swLog.AutoFlush = true;
        }

        public static void Log(string sLogLine)
        {
            Logger.swLog.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ": " + sLogLine);
            Logger.swLog.WriteLine("---");
            Logger.swLog.Flush();
        }

        public static void LogStack(string sLogLine, string sExLine)
        {
            Logger.swLog.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ": " + sLogLine + "\r\n\n" + sExLine);
            Logger.swLog.WriteLine("---");
            Logger.swLog.Flush();
        }

        public static void CloseLogger()
        {
            Logger.swLog.Flush();
            Logger.swLog.Close();
        }
    }
}
