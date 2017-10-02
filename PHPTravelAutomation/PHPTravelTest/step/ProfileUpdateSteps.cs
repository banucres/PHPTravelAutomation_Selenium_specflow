using PHPTravelAutomation.Base;
using PHPTravelTest.Pages;
using PHPTravelTest.Pages.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PHPTravelTest.step
{
    [Binding]
    public sealed class ProfileUpdateSteps:BaseStep

    {
       


        [Then(@"I clear already existing details")]
        public void ThenIClearAlreadyExistingDetails()
        {
           CurrentPage.As<AccountMyProfilePage>().ClearExistingTextDetails();
        }

        [Then(@"I enter the following details")]
        public void ThenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<AccountMyProfilePage>().UpdateProfiledetails(data.Address1, data.Address2);
        }


    }
}
