using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace SeleniumTests.Pages
{
    public class ContactUsPage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By submitButtonLocator = By.CssSelector("#submitMessage");
        private By errorMessageLocator = By.CssSelector(".alert-danger li");

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
        }

        public void GoToPage()
        {
            string url = ConfigurationManager.AppSettings["url"];
            driver.Navigate().GoToUrl($"{url}/index.php?controller=contact");
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(submitButtonLocator).Click();
        }

        public string GetErrorMessageText()
        {
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Text;
        }
        public bool IsErrorMessageDisplayed()
        {
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Displayed;
        }

    }
}
