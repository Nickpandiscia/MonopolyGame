using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Engine.Tools;

namespace Monopoly.Core
{
    public static class Logger
    {
      
        public static void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(Constants.LogPath))
            {
                sw.WriteLine($"{DateTime.Now} | {message}");
            }
        }
    }
}
