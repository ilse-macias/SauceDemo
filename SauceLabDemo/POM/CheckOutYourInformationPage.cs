using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabDemo.Constants
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
            _firstNameField = _driver.FindElement(By.Id("first-name"));
            _firstNameField.SendKeys(firstName);

            _lastNameField = _driver.FindElement(By.Id("last-name"));
            _lastNameField.SendKeys(lastName);

            _zipCodeField = _driver.FindElement(By.Id("postal-code"));
            _zipCodeField.SendKeys(zipCode);

            _continueButton = _driver.FindElement(By.Id("continue"));
            _continueButton.Click();
        }
    }
}