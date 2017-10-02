using PHPTravelAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PHPTravelTest.Hooks
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize():base(BrowserType.Chrome)
        {
            InitializeSettings();
        

        }
        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

    }
}
