using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class LinksPage : BaseForm
    {
        public LinksPage() : base(new TextField(By.XPath("//div[contains(text(), 'Links')]"), "LinksPage Unique Element"), "Links")
        {
        }

        private Button homeLink = new Button(By.XPath("//a[@id='simpleLink']"), "Home");

        public void WaitAndClickHomeLink()
        {
            WaitConditionals.WaitForDisplayed(homeLink);
            homeLink.Click();
        }
    }
}