using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sampleshweta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.co.in/");
            driver.Manage().Window.Maximize();

        }
    }
}
