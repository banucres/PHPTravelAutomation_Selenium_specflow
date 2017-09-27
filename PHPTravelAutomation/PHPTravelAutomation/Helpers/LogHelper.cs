﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelAutomation.Helpers
{
    public class LogHelper
    {
        private static string _logFileName = String.Format("{0:yyyy-mm-dd-hhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;

        public static void CreateLogFile()
        {
            string dir = @"C:\Banu\PHPTravelAutomation\Log\";
            if (Directory.Exists(dir))
            {
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
        }

        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("  {0}", logMessage);
            _streamw.Flush();
        }


    }
}
