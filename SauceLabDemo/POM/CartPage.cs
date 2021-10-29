using OpenQA.Selenium;
using SauceLabDemo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SauceLabDemo
{
    public class CartPage
    {
        private IWebDriver _driver;
        private IWebElement _checkoutButton;

        public CartPage(IWebDriver _driver)
        {
            this._driver = _driver;
            _checkoutButton = _driver.FindElement(By.Id(CartLocatorsConstants.CheckOutId));
        }

        public void ClickOnCheckOutButton()
        {
            _checkoutButton.Click();
            Thread.Sleep(3000);
        }
    }
}
