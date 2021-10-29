using OpenQA.Selenium;
using System.Threading;

namespace SauceLabDemo
{
    public class CartPage
    {
        private IWebDriver _driver;
        private IWebElement _checkoutButton;

        public CartPage(IWebDriver _driver)
        {
            this._driver = _driver;
            _checkoutButton = _driver.FindElement(By.Id(CartLocators.CheckOutId));
        }

        public void ClickOnCheckOutButton()
        {
            _checkoutButton.Click();
            Thread.Sleep(3000);
        }
    }
}
