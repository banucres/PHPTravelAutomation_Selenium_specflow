using PHPTravelAutomation.Base;
using PHPTravelTest.Pages;
using PHPTravelTest.Pages.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PHPTravelTest.step
{
    [Binding]
    internal class ExtendedSteps:BaseStep
    {
        [Then(@"I click (.*) button")]
        public void ThenIClickLoginButton(string buttonName)
        {
            if (buttonName == "login")
                CurrentPage = CurrentPage.As<LoginPage>().ClickLogin();
            else if (buttonName == "submit")
                CurrentPage = CurrentPage.As<AccountMyProfilePage>().SubmitProfileButton();

        }

        [Then(@"I click (.*) Tab")]
        public void ThenIClickMyProfileTab(string tab)
        {
            if (tab == "MyProfile")
                CurrentPage = CurrentPage.As<AccountPage>().ClickAccountMyProfilePage();
        }
    }
}
