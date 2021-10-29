using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SauceLabDemo.Test
{
    public class CheckOutTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl(MainConstants.Url);
            _driver.Manage().Window.Maximize();
        }

        [Test, Description("Complete a purchase.")]
        public void Checkout()
        {
            var seconds = TimeSpan.FromSeconds(15);

            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            InventoryPage inventory = new InventoryPage(_driver);
            inventory.AddOneSieProductToCart();
            inventory.ClickOnCartIcon();

            CartPage cart = new CartPage(_driver);
            cart.ClickOnCheckOutButton();

            CheckOutYourInformationPage checkout = new CheckOutYourInformationPage(_driver);
            checkout.FillOutTheInformation(CheckoutConstants.FirstName, CheckoutConstants.LastName, CheckoutConstants.ZipCode);
            _driver.Manage().Timeouts().ImplicitWait = seconds;

            CheckOutOverview checkoutTwo = new CheckOutOverview(_driver);
            checkoutTwo.CheckOutLastStep();
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
