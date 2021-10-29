using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SauceLabDemo
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
            _burgerMenuIcon = _driver.FindElement(By.Id(InventoryLocators.BurgerMenuId));
        }

        public void ClickOnLogout()
        {
            _burgerMenuIcon.Click();
            Thread.Sleep(5000);

            _logoutLink = _driver.FindElement(By.Id(InventoryLocators.LogoutLinkId));
            _logoutLink.Click();
        }

        public void SortProducts()
        {
            _sortProduct = _driver.FindElement(By.ClassName(InventoryLocators.SortDropDownListCss));

            SelectElement selectElement = new SelectElement(_sortProduct);
            selectElement.SelectByValue(InventoryLocators.SelectSortValue);
            Thread.Sleep(5000);
        }

        public void AddOneSieProductToCart()
        {
            _addOneSieProduct = _driver.FindElement(By.Id(InventoryLocators.OneSieProductId));
            _addOneSieProduct.Click();
            Thread.Sleep(5000);
        }

        public void ClickOnCartIcon()
        {
            _cartIcon = _driver.FindElement(By.ClassName(InventoryLocators.CartIconCss));
            _cartIcon.Click();
            Thread.Sleep(5000);
        }
    }
}
