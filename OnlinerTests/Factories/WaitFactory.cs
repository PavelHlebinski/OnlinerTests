using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OnlinerTests.Factories
{
    public class WaitFactory
    {
        private static WebDriverWait _wait;

        public static WebDriverWait GetWait(int timeOutInSeconds) => _wait ??= SetupWait(DriverFactory.GetDriver(), timeOutInSeconds);

        private static WebDriverWait SetupWait(IWebDriver driver, int timeOutInSeconds) => new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
    }
}
