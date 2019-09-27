using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Pages
{
    public class CategoryPage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By productCounterLocator = By.CssSelector(".heading-counter");
        private By productLocator = By.CssSelector("div.product-container");

        public CategoryPage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 25));
        }

        public void GoToPage(int num)
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?id_category="+num+"&controller=category");
        }

        /*  public void ClickSubmitButton()
          {
              driver.FindElement(submitButtonLocator).Click();
          }*/


        public string GetDispNumberOfProducts()
        {
            var productcounter = driver.FindElement(productCounterLocator);
            return productcounter.Text;
        }
        public string GetActNumberOfProducts()
        {
            var webElements = driver.FindElements(productLocator);
            return webElements.Count.ToString();
        }

        /* public bool IsErrorMessageDisplayed()
         {
             var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
             return errorMessage.Displayed;
         }*/

    }
}


