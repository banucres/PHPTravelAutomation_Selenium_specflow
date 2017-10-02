using PHPTravelAutomation.Base;
using PHPTravelAutomation.ConfigElement;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelAutomation.Config
{
    public class ConfigReader
    {
        public static  string InitializeTest()
        {
            return ConfigurationManager.AppSettings["AUT"].ToString();
        }

        public static void SetFrameworkSettings()
        {
            Settings.AUT = PHPTestConfiguration.PHPSettings.TestSettings["staging"].AUT;
            Settings.TestType = PHPTestConfiguration.PHPSettings.TestSettings["staging"].TestType;
            Settings.IsLog = PHPTestConfiguration.PHPSettings.TestSettings["staging"].IsLog;
            //Settings.IsReporting = EATestConfiguration.EASettings.TestSettings["staging"].IsReadOnly;
            Settings.LogPath = PHPTestConfiguration.PHPSettings.TestSettings["staging"].LogPath;
            //Settings.AppConnectionString = appConnection.Value.ToString();
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), PHPTestConfiguration.PHPSettings.TestSettings["staging"].Browser);
        }
    }
}
