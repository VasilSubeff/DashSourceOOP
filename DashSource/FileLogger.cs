using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashSource
{
    public class FileLogger
    {
        public string filePath = Properties.Settings.Default.logPathSetting;

        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(this.filePath, true))
            {
                sw.WriteLine(DateTime.Now + ": " + message);
                sw.Close();
            }
        }
    }

    public static class LogHelper
    {
        private static FileLogger logger = null;

        public static void Log(string message)
        {
            logger = new FileLogger();
            logger.Log(message);
        }

    }
}
