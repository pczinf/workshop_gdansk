using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTests
{

    
    public class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            var waittime = new System.TimeSpan(0, 0, 3);
            driver.Manage().Timeouts().ImplicitWait = waittime;
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
