using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceLabDemo.Constants;
using System.Collections.Generic;
using System.Threading;


namespace SauceLabDemo.POM
{
    public class InventoryPage
    {
        private IWebDriver _driver;
        private IWebElement _burgerMenuIcon;
        private IWebElement _logoutLink;
        private IWebElement _sortProduct;

        private IWebElement _addOneSieProduct;
        private IWebElement _cartIcon;

        public InventoryPage(IWebDriver _driver)
        {
            this._driver = _driver;
            _burgerMenuIcon = _driver.FindElement(By.Id(InventoryLocatorConstants.BurgerMenuId));
        }

        public void ClickOnLogout()
        {
            _burgerMenuIcon.Click();
            Thread.Sleep(5000);

            _logoutLink = _driver.FindElement(By.Id(InventoryLocatorConstants.LogoutLinkId));
            _logoutLink.Click();
        }

        public void SortProducts()
        {
            _sortProduct = _driver.FindElement(By.ClassName(InventoryLocatorConstants.SortDropDownListCss));

            SelectElement selectElement = new SelectElement(_sortProduct);
            selectElement.SelectByValue(InventoryLocatorConstants.SelectSortValue);
            Thread.Sleep(5000);
        }

        public void AddOneSieProductToCart()
        {
            _addOneSieProduct = _driver.FindElement(By.Id(InventoryLocatorConstants.OneSieProductId));
            _addOneSieProduct.Click();
            Thread.Sleep(5000);
        }

        public void ClickOnCartIcon()
        {
            _cartIcon = _driver.FindElement(By.ClassName(InventoryLocatorConstants.CartIconCss));
            _cartIcon.Click();
            Thread.Sleep(5000);
        }
    }
}
