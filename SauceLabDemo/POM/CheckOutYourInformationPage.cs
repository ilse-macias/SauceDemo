using OpenQA.Selenium;

namespace SauceLabDemo
{
    public class CheckOutYourInformationPage
    {
        private IWebDriver _driver;
        private IWebElement _firstNameField;
        private IWebElement _lastNameField;
        private IWebElement _zipCodeField;
        private IWebElement _continueButton;

        public CheckOutYourInformationPage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void FillOutTheInformation(string firstName, string lastName, string zipCode)
        {
            _firstNameField = _driver.FindElement(By.Id(CheckOutYourInformationLocators.FirstNameId));
            _firstNameField.SendKeys(firstName);

            _lastNameField = _driver.FindElement(By.Id(CheckOutYourInformationLocators.LastNameId));
            _lastNameField.SendKeys(lastName);

            _zipCodeField = _driver.FindElement(By.Id(CheckOutYourInformationLocators.ZipCodeId));
            _zipCodeField.SendKeys(zipCode);

            _continueButton = _driver.FindElement(By.Id(CheckOutYourInformationLocators.ContinueButtonId));
            _continueButton.Click();
        }
    }
}