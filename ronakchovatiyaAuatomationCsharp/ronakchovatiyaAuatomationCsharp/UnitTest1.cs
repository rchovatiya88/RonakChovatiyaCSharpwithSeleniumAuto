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
// Go to ebay page 
            driver.Navigate().GoToUrl("http://www.ebay.com");

//Go to search box and type 'elephant handicraft'
            IWebElement searchBox = driver.FindElement(By.XPath(".//*[id='gh-ac']"));
            searchBox.SendKeys("elephant handicraft");
//click search button
            IWebElement clickSearch = driver.FindElement(By.XPath(".//*[id='gh-btn']"));
            clickSearch.Click();

// Extract the search results and save it to result.txt
            var result = driver.FindElementByXPath(".//*[@id='Results']").Text;
            File.WriteAllText("result.txt", result);

// Also take a screenshot and save it into result.jpg
             driver.GetScreenshot().SaveAsFile(@"result.png", ImageFormat.jpg);
            
//Close the browser
            driver.Quit();

        }
    }
}

   


