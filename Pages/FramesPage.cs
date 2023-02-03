using OpenQA.Selenium;
using System.Linq;
using Task3_1.Bases;
using Task3_1.Driver;
using Task3_1.Elements;
using Task3_1.Utils;

namespace Task3_1.Pages
{
    public class FramesPage : BaseForm
    {
        public readonly IWebDriver driver;
        public FramesPage() : base(new TextField(By.XPath("//div[contains(text(), 'Frames')]"), "FramesPage Unique Element"), "Frames")
        {
            driver = SeleniumDriver.GetDriver();
        }

        private By upperFrame = By.Id("frame1");
        private By lowerFrame = By.Id("frame2");
        private By frameHeaderLocator = By.Id("sampleHeading");

        public bool AreFramesTextsEqual()
        {
            DriverUtils.SwitchToFrame(upperFrame);
            var upperFrameText = driver.FindElements(frameHeaderLocator).FirstOrDefault()?.Text;

            DriverUtils.SwitchToDefaultContent();

            DriverUtils.SwitchToFrame(lowerFrame);
            var lowerFrameText = driver.FindElements(frameHeaderLocator).FirstOrDefault()?.Text;

            return string.Equals(upperFrameText, lowerFrameText);
        }
    }
}