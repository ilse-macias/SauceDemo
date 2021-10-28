using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauceLabDemo.Constants;
using SauceLabDemo.POM;

namespace SauceLabDemo.Test
{
    public class InventoryTest
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

        [Test, Description("Logout from the home page")]
        public void LogoutFromHomePage()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            InventoryPage inventoryPage = new InventoryPage(_driver);
            inventoryPage.ClickOnLogout();
        }

        [Test, Description("Sort products by Price (low to high)")]
        public void SortProductByPriceDescending()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            InventoryPage inventory = new InventoryPage(_driver);
            inventory.SortProducts();
        }

        [Test, Description("Validate the correct product was added to the cart.")]
        public void AddSauceLabsOnesie()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.LoginTheWebsite(LoginConstants.Username, LoginConstants.Password);

            InventoryPage inventoryPage = new InventoryPage(_driver);
            inventoryPage.AddOneSieProductToCart();
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
