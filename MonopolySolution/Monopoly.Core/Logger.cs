using System;
using System.IO;

namespace Monopoly.Core
{
    public static class Logger
    {
        public static void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(Constants.LogPath))
            {
                sw.WriteLine($"{DateTime.Now.ToString("mm:ss.fff")} | {message}");
            }
        }
    }
}
