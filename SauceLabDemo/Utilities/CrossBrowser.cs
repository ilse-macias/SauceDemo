using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SauceLabDemo
{
    public class CrossBrowser
    {
        private IWebDriver _driver;
        public CrossBrowser(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public IWebDriver Driver(BrowsersOption.Browser browserOption)
        {
            switch (browserOption)
            {
                case BrowsersOption.Browser.Chrome:
                    return new ChromeDriver();

                case BrowsersOption.Browser.Firefox:
                    return new FirefoxDriver();

                default:
                    return default(IWebDriver);
            }
        }
    }
}
