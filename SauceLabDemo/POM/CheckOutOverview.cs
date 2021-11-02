using OpenQA.Selenium;

namespace SauceLabDemo
{
    public class CheckOutOverview
    {
        private IWebDriver _driver;
        private IWebElement _finishButton;

        public CheckOutOverview(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void CheckOutLastStep()
        {
            _finishButton = _driver.FindElement(By.Id(CheckOutOverviewLocators.FinishButtonId));
            _finishButton.Click();
        }
    }
}
