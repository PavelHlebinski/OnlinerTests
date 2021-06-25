using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlinerTests.Factories
{
    public class DriverFactory
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver() => _driver ??= SetupDriver();

        private static IWebDriver SetupDriver() => new ChromeDriver(GetOptions());

        private static ChromeOptions GetOptions()
        {
            var options = new ChromeOptions();
            options.AddArguments("start-maximized");
            return options;
        }
    }
}
