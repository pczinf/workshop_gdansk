using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumTests
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;
        [Test]
        public void Test01()
        {
            driver = new ChromeDriver();
            Assert.AreEqual(2, 1);
           
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
