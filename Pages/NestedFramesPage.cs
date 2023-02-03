using OpenQA.Selenium;
using Task3_1.Bases;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class NestedFramesPage : BaseForm
    {

        public NestedFramesPage() : base(new TextField(By.XPath("//div[contains(text(), 'Nested Frames')]"), "NestedFramesPage Unique Element"), "Nested Frames")
        {

        }

        private By parentFrame = By.XPath("//iframe[@id='frame1']");
        private By childFrame = By.XPath("//iframe[contains(@srcdoc, 'Child Iframe')]");


        public void SwitchToParentFrame() => DriverUtils.SwitchToFrame(parentFrame);

        public void SwitchToChildFrame() => DriverUtils.SwitchToFrame(childFrame);

        public bool TextExistsOnPage(string text)
        {
            TextField field = new TextField(By.XPath($"//*[text()='{text}']"), $"{text} textField");
            WaitConditionals.WaitForDisplayed(field);
            return field.IsDisplayed();
        }
    }
}