using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SauceLabDemo
{
    public class InventoryTest
    {
        private IWebDriver _driver;
        private static ExtentTest test;
        private static ExtentReports extent;

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
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl(MainConstants.Url);
            _driver.Manage().Window.Maximize();
        }

        [Test, Description("Logout from the home page")]
        public void LogoutFromHomePage()
        {
            test = null;
            test = extent.CreateTest("Logout from the home page");

            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            InventoryPage inventoryPage = new InventoryPage(_driver);
            inventoryPage.ClickOnLogout();

            test.Log(Status.Pass, "Test Pass");
        }

        [Test, Description("Sort products by Price (low to high)")]
        public void SortProductByPriceDescending()
        {
            test = null;
            test = extent.CreateTest("Sort products by Price (low to high)");

            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            InventoryPage inventory = new InventoryPage(_driver);
            inventory.SortProducts();

            test.Log(Status.Pass, "Test Pass");
        }

        [Test, Description("Validate the correct product was added to the cart.")]
        public void AddSauceLabsOnesie()
        {
            test = null;
            test = extent.CreateTest("Validate the correct product was added to the cart.");

            LoginPage loginPage = new LoginPage(_driver);
            loginPage.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            InventoryPage inventoryPage = new InventoryPage(_driver);
            inventoryPage.AddOneSieProductToCart();

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
