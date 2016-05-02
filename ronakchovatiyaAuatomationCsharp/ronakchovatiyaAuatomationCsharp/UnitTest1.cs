using System;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using NUnit.Framework;



namespace UnitTest1
{
    [TestFixture]
    public class extractSearchTerm
    {
        [SetUp]
        public void SetupTest()
        {

        }
        [Test]
        public void OpenBrowser()
        {

            IWebDriver driver = new ChromeDriver();
            // Go to a page 
            driver.Navigate().GoToUrl("http://www.ebay.com");

            // Get the page elements
            IWebElement searchBox = driver.FindElement(By.XPath(".//*[id='gh-ac']"));
            searchBox.SendKeys("elephant handicraft");

            IWebElement clickSearch = driver.FindElement(By.XPath(".//*[id='gh-btn']"));
            clickSearch.Click();
            driver.Quit();

        }
    }
}

   



// Extract the text and save it into result.txt
// var result = driver.FindElementByXPath("//div[@id='case_login']/h3").Text;
// File.WriteAllText("result.txt", result);

// Take a screenshot and save it into screen.png
// driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);