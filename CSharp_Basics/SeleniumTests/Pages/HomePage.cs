using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        //"ul.sf-menu > li > a[title='" + categ + "']"
        //private By categoryLocator = By.CssSelector("ul.sf-menu > li > a[title='Dresses']");
        // private By errorMessageLocator = By.CssSelector(".alert-danger li");

        public By categoryLocator(string categ)
        {
            return By.CssSelector("ul.sf-menu > li > a[title='" + categ + "']");
        }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new System.TimeSpan(0, 0, 15));
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        
        public void ClickCategory(string categ)
        {
            /*var categoryHeader = driver.FindElement(categoryLocator(categ));
            categoryHeader.Click();*/
            driver.FindElement(categoryLocator(categ)).Click();

        }

    }
}
