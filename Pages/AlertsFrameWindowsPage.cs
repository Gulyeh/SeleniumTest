using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class AlertsFrameWindowsPage : BaseForm
    {
        public AlertsFrameWindowsPage() : base(new TextField(By.XPath("//div[contains(text(), 'Alerts, Frame & Windows')]"), "AlertsFrameWindowsPage Unique Element"), "Alerts, Frame & Windows")
        {

        }

        private Button alertsMenuButton = new Button(By.XPath("//span[text()='Alerts']"), "Alerts");
        private Button framesMenuButton = new Button(By.XPath("//span[text()='Frames']"), "Frames");
        private Button nestedFramesMenuButton = new Button(By.XPath("//span[text()='Nested Frames']"), "Nested Frames");
        private Button browserWindowsMenuButton = new Button(By.XPath("//span[text()='Browser Windows']"), "Browser Windows");

        public void WaitAndClickAlertsMenuButton()
        {
            WaitConditionals.WaitForDisplayed(alertsMenuButton);
            alertsMenuButton.Click();
        }

        public void WaitAndClickNestedFramesMenuButton()
        {
            WaitConditionals.WaitForDisplayed(nestedFramesMenuButton);
            nestedFramesMenuButton.Click();
        }

        public void WaitAndClickFramesMenuButton()
        {
            WaitConditionals.WaitForDisplayed(framesMenuButton);
            framesMenuButton.Click();
        }

        public void WaitAndClickBrowserWindows()
        {
            WaitConditionals.WaitForDisplayed(browserWindowsMenuButton);
            browserWindowsMenuButton.Click();
        }
    }
}