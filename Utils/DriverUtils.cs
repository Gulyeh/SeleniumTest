using OpenQA.Selenium;
using System.Linq;
using Task3_1.Driver;

namespace Task3_1.Utils
{
    public static class DriverUtils
    {
        public static void SwitchTab(int index)
        {
            var driver = SeleniumDriver.GetDriver();
            driver.SwitchTo().Window(driver.WindowHandles[index]);
        }

        public static void CloseCurrentTab() => SeleniumDriver.GetDriver().Close();

        public static int GetCurrentTabsCount() => SeleniumDriver.GetDriver().WindowHandles.Count;

        public static void SwitchToDefaultContent() => SeleniumDriver.GetDriver().SwitchTo().DefaultContent();

        public static void SwitchToFrame(By locator)
        {
            Logger.Info($"Switching to iframe");
            var driver = SeleniumDriver.GetDriver();
            var elements = driver.FindElements(locator);
            driver.SwitchTo().Frame(elements.FirstOrDefault());
        }
    }
}