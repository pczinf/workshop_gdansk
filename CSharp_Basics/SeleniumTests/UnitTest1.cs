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

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test01()
        {
            Assert.AreEqual(2, 1);
           
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
