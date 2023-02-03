using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class MainPage : BaseForm
    {
        public MainPage() : base(new Button(By.XPath("//img[contains(@class, 'banner-image')]"), "MainPage Unique Element"), "Main")
        {

        }

        private Button alertsFrameWindowsButton = new Button(By.XPath("//h5[contains(text(), 'Alerts')]"), "Alerts, Frame & Windows");
        private Button elementsButton = new Button(By.XPath("//h5[contains(text(), 'Elements')]"), "Elements");

        public void WaitAndClickAlertsFrameWindowsButton()
        {
            WaitConditionals.WaitForDisplayed(alertsFrameWindowsButton);
            alertsFrameWindowsButton.Click();
        }
        public void WaitAndClickElementsButton()
        {
            WaitConditionals.WaitForDisplayed(elementsButton);
            elementsButton.Click();
        }
    }
}