using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTestProject
{
    public class GitHubTest
    {

        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void SetUpDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckGitHubSearch()
        {

            driver.Navigate().GoToUrl("https://3september.ru/");

            IWebElement searchInput = driver.FindElement(By.XPath("//*[@id='calendar']"));

            while (true)
            {
                searchInput.Click();
            }
        }

        [OneTimeTearDown]
        public static void TearDownDriver()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            driver.Quit();
        }
    }
}
