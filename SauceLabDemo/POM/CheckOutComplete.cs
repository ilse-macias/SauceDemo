using OpenQA.Selenium;

namespace SauceLabDemo.POM
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
            _backHomeButton = _driver.FindElement(By.Id("back-to-products"));
            _backHomeButton.Click();
        }
    }
}
