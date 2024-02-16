using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTest
{
    internal class Scraper
    {
        private IWebDriver _webDriver;
        public Scraper()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }
        public void Navigate()
        {
            _webDriver.Navigate().GoToUrl("https:www.github.com");
        }
    }
}
