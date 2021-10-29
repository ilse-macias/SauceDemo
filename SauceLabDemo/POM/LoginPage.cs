using OpenQA.Selenium;

namespace SauceLabDemo
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
            _usernameField = _driver.FindElement(By.Id(LoginLocators.UsernameId));
            _passwordField = _driver.FindElement(By.Id(LoginLocators.PasswordId));
            _loginButton = _driver.FindElement(By.Id(LoginLocators.LoginButtonId));
        }

        public void LoginTheWebsite(string username, string password)
        {
            _usernameField.SendKeys(username);
            _passwordField.SendKeys(password);
            _loginButton.Click();
        }

    }
}
