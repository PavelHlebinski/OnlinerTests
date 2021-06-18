using OnlinerTests.Factories;
using System;

namespace OnlinerTests.Pages.BasePage
{
    public class BasePage
    {
        public void OpenUrl(string url)
        {
            try
            {
                DriverFactory.GetDriver().Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }
    }
}
