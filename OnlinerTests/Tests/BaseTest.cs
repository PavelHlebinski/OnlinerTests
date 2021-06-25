using NUnit.Framework;
using OnlinerTests.Factories;
using OnlinerTests.Pages.BasePage;
using OnlinerTests.Pages.Pages;
using OnlinerTests.Settings;
using OpenQA.Selenium;

namespace OnlinerTests.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver = DriverFactory.GetDriver();
        protected readonly string URL = AppSettings.ReadSettings("URL");
        protected BasePage BasePage = new BasePage();
        protected MainPage MainPage = new MainPage();
        protected AutoPage AutoPage = new AutoPage();

        [SetUp]
        public void SetUp() => BasePage.OpenUrl(URL);


        [TearDown]
        public void DriverQuit() => Driver.Quit();
    }
}
