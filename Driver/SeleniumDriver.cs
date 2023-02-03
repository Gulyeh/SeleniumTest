using OpenQA.Selenium;
using Task3_1.Factory;
using Task3_1.Utils;

namespace Task3_1.Driver
{
    public static class SeleniumDriver
    {
        private static IWebDriver? Driver { get; set; }

        public static IWebDriver GetDriver()
        {
            if (Driver is null)
            {
                var browserFactory = new BrowserFactory();
                var driver = browserFactory.SelectBrowser(Config.ConfigData.Browser, Config.ConfigData.BrowserArguments);
                driver.Manage().Timeouts().PageLoad = Config.ConfigData.PageLoadWait;
                driver.Manage().Window.Maximize();
                Driver = driver;
            }
            return Driver;
        }

        public static void Dispose()
        {
            Driver?.Quit();
            Driver = null;
        }
    }
}