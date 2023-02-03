using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class AlertsPage : BaseForm
    {
        public AlertsPage() : base(new TextField(By.XPath("//div[contains(text(), 'Alerts')]"), "AlertsPage Unique Element"), "Alerts")
        {

        }

        private Button alertButton = new Button(By.XPath("//button[@id='alertButton']"), "Alert");
        private Button confirmBoxButton = new Button(By.XPath("//button[@id='confirmButton']"), "Confirm");
        private Button promptAlertButton = new Button(By.XPath("//button[@id='promtButton']"), "Prompt");

        public void WaitAndClickAlertButton()
        {
            WaitConditionals.WaitForDisplayed(alertButton);
            alertButton.Click();
        }

        public void WaitAndClickConfirmBoxButton()
        {
            WaitConditionals.WaitForDisplayed(confirmBoxButton);
            confirmBoxButton.Click();
        }

        public void WaitAndClickPromptAlertButton()
        {
            WaitConditionals.WaitForDisplayed(promptAlertButton);
            promptAlertButton.Click();
        }

        public bool TextExistsOnPage(string? text)
        {
            if (text is null) return false;

            TextField field = new TextField(By.XPath($"//*[text()='{text}']"), "Prompt text");
            return field.IsDisplayed();
        }
    }
}