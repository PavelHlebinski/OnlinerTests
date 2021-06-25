using OnlinerTests.Factories;
using System;
using OpenQA.Selenium;

namespace OnlinerTests.Pages.BasePage
{
    public class BasePage
    {
        protected IWebDriver Driver = DriverFactory.GetDriver();
        public void OpenUrl(string url)
        {
            try
            {
                Driver.Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }
    }
}
