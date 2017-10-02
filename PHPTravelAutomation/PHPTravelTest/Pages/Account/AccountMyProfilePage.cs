using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPTravelTest.Pages.Account
{
    public class AccountMyProfilePage:BasePage
    {
        [FindsBy(How =How.Name,Using = "address1")]
        IWebElement txtaddress1 { get; set; }

        [FindsBy(How = How.Name, Using = "address2")]
        IWebElement txtaddress2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-action.btn-block.updateprofile")]
        IWebElement btnProfilesubmit { get; set; }

        [FindsBy(How = How.LinkText, Using = "Wishlist")]
        IWebElement lnkWishlist { get; set; }


        public void ClearExistingTextDetails()
        {
            txtaddress1.Clear();
            txtaddress2.Clear();

        }
        public void UpdateProfiledetails(string address1,string address2)
        {
            txtaddress1.SendKeys(address1);
            txtaddress2.SendKeys(address2);
            //btnProfilesubmit.Click();            
        }

        public AccountPage SubmitProfileButton()
        {
            btnProfilesubmit.Submit();
            return GetInstance<AccountPage>();
        }
    }
}
