using NUnit.Framework;
using OnlinerTests.Factories;
using OnlinerTests.Pages.BasePage;
using OnlinerTests.Pages.Pages;
using OnlinerTests.Settings;

namespace OnlinerTests.Tests
{
    public class EmailTets
    {
        private readonly string UserName = AppSettings.ReadSettings("UserName");
        private readonly string Password = AppSettings.ReadSettings("Password");
        private readonly string URL = AppSettings.ReadSettings("URL");
        private BasePage BasePage = new BasePage();
        private MainPage MainPage = new MainPage();
        private LoginPage LoginPage = new LoginPage();

        [TestCase("Подтвердите ваш e-mail", "Onliner.by", TestName = "Email api test")]
        public void EmailApiTest(string confirmText, string senderName)
        {
            BasePage.OpenUrl(URL);
            MainPage.OpenLoginPage();
            LoginPage.LogIn(UserName, Password);
            LoginPage.SendEmailTextCheck(confirmText);
            LoginPage.CheckMailDelivered(senderName);
        }

        [TearDown]
        public void DriverQuit() => DriverFactory.QuitDriver();
    }
}
