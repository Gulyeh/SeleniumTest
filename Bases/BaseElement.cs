using OpenQA.Selenium;
using Task3_1.Driver;
using Task3_1.Utils;

namespace Task3_1.Bases
{
    public abstract class BaseElement
    {
        private readonly By locator;
        private readonly string name;
        private readonly IWebDriver driver;

        protected BaseElement(By Locator, string name)
        {
            locator = Locator;
            this.name = name;
            this.driver = SeleniumDriver.GetDriver();
        }

        protected IWebElement FindElement()
        {
            Logger.Info($"Looking for {name} element");
            return driver.FindElement(locator);
        }

        public void Click()
        {
            FindElement().Click();
            Logger.Info($"Clicked {name} element");
        }

        public bool IsDisplayed()
        {
            Logger.Info($"Checking if {name} element is displayed");
            return FindElement().Displayed;
        }

        public bool IsEnabled()
        {
            Logger.Info($"Checking if {name} element is enabled");
            return FindElement().Enabled;
        }
    }
}