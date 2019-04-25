using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace ConsoleApp5
{
    public class SeleniumWrapper
    {
        protected static IWebDriver driver = (IWebDriver)ScenarioContext.Current["browser"];

        protected void OpenPage(string page)
        {
            driver.Navigate().GoToUrl(page);
        }
        protected IWebElement FindElement(By locator)
        {
            return driver.FindElement(locator);
        }
    }
}