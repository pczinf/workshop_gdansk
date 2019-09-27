﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace SeleniumTests
{
    [TestFixture]
    public class CategoriesTest : TestBase
    {

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

        [Test]
        public void Test02()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Women']"));
            categoryHeader.Click();
            var productcounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productcounter.Text;

            StringAssert.Contains("7", text);
        }
        [Test]
        public void Test03()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='T-shirts']"));
            categoryHeader.Click();
            var productcounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productcounter.Text;

            StringAssert.Contains("1", text);
        }

        [Test]
        public void Test01a()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='Dresses']"));
            categoryHeader.Click();
           
            var productcounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productcounter.Text;
            var webElements = driver.FindElements(By.CssSelector("div.product-container"));
            string actualElementCount = webElements.Count.ToString();
            StringAssert.Contains(actualElementCount, text);
        }

        [TestCase("Dresses")]
        [TestCase("Women")]
        [TestCase("T-shirts")]
        public void Test123(string categ)
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li > a[title='"+ categ+"']"));
            categoryHeader.Click();

            var productcounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productcounter.Text;
            var webElements = driver.FindElements(By.CssSelector("div.product-container"));
            string actualElementCount = webElements.Count.ToString();
            StringAssert.Contains(actualElementCount, text);
        }


    }
}
