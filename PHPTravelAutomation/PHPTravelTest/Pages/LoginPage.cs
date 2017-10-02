using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelAutomation.Base;
using PHPTravelAutomation.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelTest.Pages
{
    class LoginPage: BasePage
    {
        [FindsBy(How =How.Name,Using = "username")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How =How.Name,Using = "password")]
        IWebElement txtPassword { get; set; }


        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-action.btn-lg.btn-block.loginbtn")]
        IWebElement buttonLogin { get; set; }


        public void Login(string userName,String password)
        {
           txtUserName.SendKeys(userName);
           txtPassword.SendKeys(password);
         
           
        }

        public void CheckIfLoginExist()
        {
            buttonLogin.AssertElementPresent();
        }

        public AccountPage ClickLogin()
        {
            buttonLogin.Click();
            return GetInstance<AccountPage>();
        }
    }
}
