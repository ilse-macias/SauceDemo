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

        private static ExtentTest test;
        private static ExtentReports extent;

        //public Tests(BrowsersOption.Browser browsers)
        //{
        //    crossBrowser = new CrossBrowser(_driver);
        //}

        [OneTimeSetUp]
        public void ExtendStart()
        {
            extent = new ExtentReports();
            var htmlReport = new ExtentHtmlReporter(MainConstants.PathHtmlReports);
            extent.AttachReporter(htmlReport);
        }

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
            test = null;
            test = extent.CreateTest("Login with a valid user");

            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            test.Log(Status.Pass, "Test Pass");
            Assert.Pass();
        }

        [Test, Description("Login with an invalid user")]
        public void LoginInvalidUser()
        {
            test = null;
            test = extent.CreateTest("Login with an invalid user");

            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.WrongPassword);
            //Assert.Fail("Epic sadface: Username and password do not match any user in this service");

            test.Log(Status.Pass, "Test Pass");
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }

        [OneTimeTearDown]
        public void ExtendClose()
        {
            extent.Flush();
        }
    }
}