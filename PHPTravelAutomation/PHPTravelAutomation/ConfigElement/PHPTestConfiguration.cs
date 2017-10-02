using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelAutomation.ConfigElement
{
   public  class PHPTestConfiguration : ConfigurationSection
    {
        private static PHPTestConfiguration _testConfig = (PHPTestConfiguration)ConfigurationManager.GetSection("PHPTestConfiguration");

        public static PHPTestConfiguration PHPSettings { get { return _testConfig; } }

        [ConfigurationProperty("testSettings")]
        public PHPFrameworkElementCollection TestSettings { get { return (PHPFrameworkElementCollection)base["testSettings"]; } }

    }
}
