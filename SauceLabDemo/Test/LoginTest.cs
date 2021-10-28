using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SauceLabDemo.POM;
using SauceLabDemo.Constants;

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
            _driver.Manage().Window.Maximize();
        }

        [Test, Description("Login with a valid user")]
        public void LoginWithAValidCredentials()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            Assert.Pass();
        }

        [Test, Description("Login with an invalid user")]
        public void LoginInvalidUser()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.WrongPassword);
            Assert.Fail("Epic sadface: Username and password do not match any user in this service");
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}