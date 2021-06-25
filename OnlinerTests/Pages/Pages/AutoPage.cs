using NUnit.Framework;
using OnlinerTests.Elements;
using OpenQA.Selenium;

namespace OnlinerTests.Pages.Pages
{
    public class AutoPage 
    {
        private readonly WebElement _brand = new WebElement(By.XPath(
            "//*[@id=\"container\"]/div/div/div/div/div/div[2]/div/div/div[3]/div/div[2]/div[2]/div[3]/div[4]/div/div[2]/div[1]/div/div/div[1]/div/div[1]/div[1]"));

        private readonly WebElement _acura = new WebElement(By.XPath(
            "//*[@id=\"container\"]/div/div/div/div/div/div[2]/div/div/div[3]/div/div[2]/div[2]/div[3]/div[4]/div/div[2]/div[1]/div/div/div[1]/div/div[2]/div[2]/div/div[3]/ul/li[1]/label/div/div[2]"));

        private readonly WebElement _adler = new WebElement(By.XPath(
        "//*[@id=\"container\"]/div/div/div/div/div/div[2]/div/div/div[3]/div/div[2]/div[2]/div[3]/div[4]/div/div[2]/div[1]/div/div/div[1]/div/div[2]/div[2]/div/div[3]/ul/li[2]/label/div/div[2]"));

        private readonly WebElement _findBrand =
            new WebElement(By.XPath("//*[@id=\"list\"]/div[1]/div/div[1]/div/div/div/div"));

        public void FindAcura()
        {
            _brand.ScrollToElement();
            _brand.Click();
            _acura.Click();
        }

        public void FindAdler()
        {
            _brand.ScrollToElement();
            _brand.Click();
            _adler.Click();
        }

        public void SearchCheck(string brand) => Assert.IsTrue(IsCorrectBrandFind(brand));

        private bool IsCorrectBrandFind(string brand) => _findBrand.GetText().Contains(brand);
    }
}
