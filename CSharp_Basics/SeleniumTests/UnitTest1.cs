using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace SeleniumTests
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            var waittime = new System.TimeSpan(0, 0, 1);
            driver.Manage().Timeouts().ImplicitWait = waittime;
        }

        [Test]
        public void Test01()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Dresses']"));
            categoryHeader.Click();
            ////Thread.Sleep(1000);
            var productcounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productcounter.Text;

            StringAssert.Contains("5", text);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
