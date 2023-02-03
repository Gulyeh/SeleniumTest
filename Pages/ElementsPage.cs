using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class ElementsPage : BaseForm
    {
        public ElementsPage() : base(new TextField(By.XPath("//div[contains(text(), 'Elements')]"), "ElementsPage Unique Element"), "Elements")
        {

        }

        private Button linksMenuButton = new Button(By.XPath("//span[text()='Links']"), "Links");
        private Button webTablesMenuButton = new Button(By.XPath("//span[text()='Web Tables']"), "Web Tables");
        private Button elementsMenu = new Button(By.XPath("//div[text()='Elements']"), "Elements");

        public void WaitAndClickLinksButton()
        {
            WaitConditionals.WaitForDisplayed(linksMenuButton);
            linksMenuButton.Click();
        }
        public void WaitAndClickElementsButton()
        {
            WaitConditionals.WaitForDisplayed(elementsMenu);
            elementsMenu.Click();
        }
        public void WaitAndClickWebTablesButton()
        {
            WaitConditionals.WaitForDisplayed(webTablesMenuButton);
            webTablesMenuButton.Click();
        }
    }
}