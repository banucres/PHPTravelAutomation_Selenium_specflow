using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelAutomation.Base;
using PHPTravelAutomation.Extensions;
using PHPTravelTest.Pages.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelTest.Pages
{
    internal class AccountPage:BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Bookings")]
        public IWebElement LnkBooking { get; set; }

        [FindsBy(How = How.LinkText, Using = "My Profile")]
        public IWebElement LnkMyProfile { get; set; }

        [FindsBy(How=How.CssSelector,Using = "h3.RTL")]
        public IWebElement LoginUserName { get; set; }

        public AccountBookingsPage ClickAccountBookingsPage()
        {
            LnkBooking.Click();
            return new AccountBookingsPage();
        }
        public AccountMyProfilePage ClickAccountMyProfilePage()
        {
            LnkMyProfile.Click();
            return new AccountMyProfilePage();
        }

        public string GetLoggedInuser()
        {
            return LoginUserName.GetLinkText();
        }



    }
}
