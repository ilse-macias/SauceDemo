using NUnit.Framework;
using OpenQA.Selenium;

namespace SauceLabDemo
{
    public class CheckOutComplete
    {
        private IWebDriver _driver;
        private IWebElement _thankYouConfirmationText;
        private IWebElement _backHomeButton;

        public CheckOutComplete(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void GoToProductsPage()
        {
            _backHomeButton = _driver.FindElement(By.Id(CheckOutCompleteLocators.BackHomeButtonId));
            _backHomeButton.Click();

            Assert.AreEqual(_thankYouConfirmationText.ToString(), "THANK YOU FOR YOUR ORDER");
        }
    }
}
