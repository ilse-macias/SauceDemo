using OpenQA.Selenium;
using SauceLabDemo.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceLabDemo.POM
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private IWebElement _usernameField;
        private IWebElement _passwordField;
        private IWebElement _loginButton;
        public LoginPage(IWebDriver _driver)
        {
            this._driver = _driver;
            _usernameField = _driver.FindElement(By.Id(LoginLocatorsConstants.UsernameId));
            _passwordField = _driver.FindElement(By.Id(LoginLocatorsConstants.PasswordId));
            _loginButton = _driver.FindElement(By.Id(LoginLocatorsConstants.LoginButtonId));
        }

        public void LoginTheWebsite(string username, string password)
        {
            _usernameField.SendKeys(username);
            _passwordField.SendKeys(password);
            _loginButton.Click();
        }

    }
}
