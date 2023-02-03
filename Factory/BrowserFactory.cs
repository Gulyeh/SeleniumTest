using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using Task3_1.Enums;

namespace Task3_1.Factory
{
    public class BrowserFactory
    {
        public IWebDriver SelectBrowser(Browsers browser, IEnumerable<string>? arguments = null)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    return ChromeBrowser(arguments);
                case Browsers.FireFox:
                    return FirefoxBrowser(arguments);
                default:
                    throw new Exception("Browser is not supported");
            }
        }

        private IWebDriver ChromeBrowser(IEnumerable<string>? arguments)
        {
            var options = new ChromeOptions();
            if (arguments is not null)
            {
                foreach (var argument in arguments)
                {
                    options.AddArgument(argument);
                }
            }
            return new ChromeDriver(options);
        }

        private IWebDriver FirefoxBrowser(IEnumerable<string>? arguments)
        {
            var options = new FirefoxOptions();
            if (arguments is not null)
            {
                foreach (var argument in arguments)
                {
                    options.AddArgument(argument);
                }
            }
            return new FirefoxDriver(options);
        }
    }
}