using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SauceLabDemo
{
    public class Tests
    {
        private IWebDriver _driver;
        private CrossBrowser crossBrowser;

        public static ExtentTest test;
        public static ExtentReports extent;

        //public Tests(BrowsersOption.Browser browsers)
        //{
        //    crossBrowser = new CrossBrowser(_driver);
        //}

        [SetUp]
        public void Setup()
        {
           // _driver = crossBrowser.Driver(BrowsersOption.Browser.Chrome);
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl(MainConstants.Url);
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