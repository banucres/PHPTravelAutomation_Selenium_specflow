using PHPTravelAutomation.Base;
using PHPTravelTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PHPTravelTest.step
{
    [Binding]
    public sealed class LoginSteps:BaseStep

    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            //ScenarioContext.Current.Pending();
            //CurrentPage =
            NavigteSite();
            CurrentPage = GetInstance<LoginPage>();

        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<LoginPage>().CheckIfLoginExist();
        }

        [When(@"I enter UserName and Password and click login")]
        public void WhenIEnterUserNameAndPasswordAndClickLogin(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            CurrentPage.As<LoginPage>().Login(data.UserName, data.Password);
        }

           

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            CurrentPage = CurrentPage.As<LoginPage>().ClickLogin();         
        }

        [Then(@"I should see the username with hi")]
        public void ThenIShouldSeeTheUsernameWithHi()
        {
            if (CurrentPage.As<AccountPage>().GetLoggedInuser().Contains("Hi"))
            {
                System.Console.WriteLine("success Login");

            }
            else
            {
                System.Console.WriteLine("Unsuccess Login");

            }
        }


        
        

    }
}
