using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceLabDemo
{
    public class Tests
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Hello World");
            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}