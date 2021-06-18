using OnlinerTests.Elements;
using OpenQA.Selenium;

namespace OnlinerTests.Pages.Pages
{
    public class MainPage
    {
        private readonly WebElement _loginButton = new WebElement(By.ClassName("auth-bar__item"));

        public void OpenLoginPage() => _loginButton.Click();
    }
}
