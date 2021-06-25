using System.Threading.Tasks;
using NUnit.Framework;
using OnlinerTests.Pages.Pages;

namespace OnlinerTests.Tests
{
    [TestFixture]
    [Parallelizable]
    public class AutoPageTest : BaseTest
    {
        [TestCase("adler", TestName = "Adler")]
        public void EmailApiTest(string brand)
        {
            MainPage.OpenAutoCatalog();
        }
    }
}
