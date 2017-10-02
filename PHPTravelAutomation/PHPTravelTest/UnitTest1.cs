using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using PHPTravelAutomation.Base;
using PHPTravelTest.Pages;
using PHPTravelTest.Pages.Account;
using OpenQA.Selenium.IE;
using PHPTravelAutomation.Helpers;
using PHPTravelAutomation.Config;

namespace PHPTravelTest
{
    [TestClass]
    public class UnitTest1:Base
    {

        
        string url = ConfigReader.InitializeTest();

        

        //[TestMethod]
        //public void TestMethod1()
        //{
           

        //    string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
        //    ExcelHelper.PopulateInCollection(fileName);
        //    LogHelper.CreateLogFile();

        //    //OpenBrowser(BrowserType.Chrome);
        //    DriverContext.Browser.GoToUrl(url);
        //    LogHelper.Write("Opened the browser !!!");

        //    CurrentPage = GetInstance<LoginPage>();
        //    //CurrentPage.As<LoginPage>().Login("user@phptravels.com", "demouser");
        //    CurrentPage.As<LoginPage>().Login(ExcelHelper.ReadData(2, "Column0"), ExcelHelper.ReadData(2, "Column1"));
        //    CurrentPage =CurrentPage.As<LoginPage>().ClickLogin();
        //    CurrentPage=CurrentPage.As<AccountPage>().ClickAccountMyProfilePage();
        //    CurrentPage.As<AccountMyProfilePage>().UpdateProfile("R3, Avenue du Maroc", "R2, Avenue du Maroc");

        //}

        
    }
}
