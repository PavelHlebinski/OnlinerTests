using NUnit.Framework;
using OnlinerTests.Elements;
using OnlinerTests.Helpers;
using OpenQA.Selenium;

namespace OnlinerTests.Pages.Pages
{
    public class LoginPage
    {
        private readonly WebElement _registrationButton =
            new WebElement(By.XPath("//*[@id=\"auth-container\"]/div/div[2]/div/form/div[4]/div[1]/a"));
        private readonly WebElement _emailField = new WebElement(By.XPath("//*[@placeholder=\"Ваш e-mail\"]"));
        private readonly WebElement _passworField = new WebElement(By.XPath("//*[@placeholder=\"Придумайте пароль\"]"));
        private readonly WebElement _rePassworField = new WebElement(By.XPath("//*[@placeholder=\"Повторите пароль\"]"));
        private readonly WebElement _enterButton = new WebElement(By.XPath("//*[@id=\"container\"]//button"));
        private readonly WebElement _confirmText =
            new WebElement(By.XPath("//*[@id=\"container\"]/div/div/div/div/div[2]/div/div[1]"));

        public void LogIn(string email, string password)
        {
            _registrationButton.Click();
            _emailField.SendKeys(email);
            _passworField.SendKeys(password);
            _rePassworField.SendKeys(password);
            _enterButton.Click();
        }

        public void SendEmailTextCheck(string text) => Assert.IsTrue(IsEmailSendTextPresent(text));

        private bool IsEmailSendTextPresent(string text) => _confirmText.GetText().Contains(text);

        public void CheckMailDelivered(string senderName) => Assert.IsTrue(GmailHelper.IsMailPresent(senderName));
    }
}
