using OnlinerTests.Elements;
using OpenQA.Selenium;

namespace OnlinerTests.Pages.Pages
{
    public class MainPage : BasePage.BasePage
    {
        private readonly WebElement _loginButton = new WebElement(By.ClassName("auth-bar__item"));

        private readonly WebElement _autoCatalog =
            new WebElement(By.XPath("//*[@id=\"container\"]/div/div/header/div[3]/div/div[1]/a/img"));

        private readonly WebElement _searchFiled = new WebElement(By.XPath("//*[@id=\"fast-search\"]/form/input[1]"));

        public void OpenLoginPage() => _loginButton.Click();

        public void OpenAutoCatalog() => _autoCatalog.Click();

        public void FindItem(string itemName) => _searchFiled.SendKeys(itemName);
    }
}
