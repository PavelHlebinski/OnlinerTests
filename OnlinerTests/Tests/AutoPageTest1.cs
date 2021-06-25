using System.Threading.Tasks;
using NUnit.Framework;
using OnlinerTests.Pages.Pages;

namespace OnlinerTests.Tests
{
    [TestFixture]
    [Parallelizable]
    public class AutoPageTest1 : BaseTest
    {
        [TestCase("acura", TestName = "Acura")]
        public void EmailApiTest(string brand)
        {
            MainPage.OpenAutoCatalog();
        }
    }
}
