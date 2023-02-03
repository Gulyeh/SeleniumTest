using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Task3_1.Bases;
using Task3_1.Driver;

namespace Task3_1.Utils
{
    public static class WaitConditionals
    {
        private static WebDriverWait webDriverWait = new WebDriverWait(SeleniumDriver.GetDriver(), Config.ConfigData.WaitTime);

        public static void WaitForDisplayed(BaseElement element) => webDriverWait.Until(x => element.IsDisplayed());
        public static void WaitFor<T>(Func<IWebDriver, T> func) => webDriverWait.Until(func);
    }
}