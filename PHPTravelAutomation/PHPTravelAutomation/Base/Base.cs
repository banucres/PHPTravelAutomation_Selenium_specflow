﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PHPTravelAutomation.Base
{
    public class Base
    {
        public IWebDriver _driver { get; set; }
        public BasePage CurrentPage
        {
            get
            {
                return (BasePage)ScenarioContext.Current["currentPage"];
            }
            set
            {
                ScenarioContext.Current["currentPage"] = value;
            }
        }
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };
            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
