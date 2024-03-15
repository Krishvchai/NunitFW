using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krishna_Personal.TestMethods
{
    class BaseClass
    {
        public static IWebDriver GetWebDriver;
        protected EngagementContext EngagementContext { get; set; }
        [OneTimeSetUp]
        public void BeforeSuite()
        {
            //ToDo
        }
        [SetUp]
        public void BeforeTest()
        {
            GetWebDriver = new ChromeDriver();
            EngagementContext.Driver = GetWebDriver;
            GetWebDriver.Manage().Window.Maximize();
            GetWebDriver.Navigate().GoToUrl("");
        }
        [TearDown]
        public void GetResult()
        {

        }

        [OneTimeTearDown]
        public static void OneTimeDispose()
        {
            
        }
    }
}
