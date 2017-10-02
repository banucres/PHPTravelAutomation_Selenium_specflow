using PHPTravelAutomation.Config;
using PHPTravelAutomation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelAutomation.Base
{
    public abstract class BaseStep:Base
    {
        public virtual void NavigteSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelper.Write("Opened the browser !!!");
        }


    }
}
