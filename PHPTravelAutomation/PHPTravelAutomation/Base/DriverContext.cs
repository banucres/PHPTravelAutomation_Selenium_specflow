using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelAutomation.Base
{
    public static class DriverContext
    {
        public static IWebDriver _driver { get; set; }

        public static IWebDriver Driver { get { return _driver; } set { _driver=value; } }

        public static Browser Browser { get; set; }
    }
}
