using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class BrowserWindowsPage : BaseForm
    {
        public BrowserWindowsPage() : base(new TextField(By.XPath("//div[contains(text(), 'Browser Windows')]"), "BrowserWindowsPage Unique Element"), "Browser Windows")
        {

        }

        private Button newTabButton = new Button(By.XPath("//button[@id='tabButton']"), "New Tab");

        public void WaitAndClickNewTabButton()
        {
            WaitConditionals.WaitForDisplayed(newTabButton);
            newTabButton.Click();
        }
    }
}