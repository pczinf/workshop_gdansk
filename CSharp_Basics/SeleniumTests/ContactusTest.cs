using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumTests.Pages;

namespace SeleniumTests
{
    [TestFixture]
    class ContactusTest : TestBase
    {
        ContactUsPage sut;    // deklaracja obiektu dla strony

        [SetUp]
        public void ContactUssetup()
        {
            sut = new ContactUsPage(driver);
            sut.GoToPage();
        }

        /*[Test]
        public void TestIsError()
        {
            //driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");

            var button = driver.FindElement(By.CssSelector("#submitMessage"));
            button.Click();

            var alertbar = driver.FindElement(By.CssSelector(".alert p"));
            var alertbartext = alertbar.Text;
            string text = "error";
            StringAssert.Contains(text,alertbartext);
            Assert.That(alertbartext, Contains.Substring(text));  // wygodniejszy (?) zapis


            WebDriverWait waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert-danger li")));
            
            Assert.IsTrue(errorMessage.Displayed, "Error message wasn't displayed to user.");
            Assert.That(errorMessage.Text, Contains.Substring("Invalid email address."));
        }*/

        [Test]
        public void TestIsError()
        {
            sut.ClickSubmitButton();

            Assert.IsTrue(sut.IsErrorMessageDisplayed(), "Error message wasn't displayed to user.");

            var errorMessage = sut.GetErrorMessageText();
            Assert.That(errorMessage, Contains.Substring("Invalid email address."));
        }
    }
}
