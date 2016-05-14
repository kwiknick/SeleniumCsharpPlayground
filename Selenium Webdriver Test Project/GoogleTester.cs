using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Selenium_Webdriver_Test_Project
{
    /// <summary>
    /// Summary description for GoogleTester
    /// </summary>
    
    public class GoogleTester
    {

        //Create the reference for the browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to the Google.com homepage
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void ExecuteTest()
        {
            //find the element on the page to input into
            IWebElement searchBar = driver.FindElement(By.Name("q"));

            //Perform operations inside the element above
            searchBar.SendKeys("twitter");
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
