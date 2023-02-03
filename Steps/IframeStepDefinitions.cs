using NUnit.Framework;
using Task3_1.Pages;
using Task3_1.Utils;
using TechTalk.SpecFlow;

namespace Task3_1.Steps
{
    [Binding]
    public class IframeStepDefinitions
    {
        private readonly MainPage mainPage;
        private readonly AlertsFrameWindowsPage alertsFrameWindowsPage;
        private readonly NestedFramesPage nestedFramesPage;
        private readonly FramesPage framesPage;

        public IframeStepDefinitions()
        {
            this.mainPage = new MainPage();
            this.alertsFrameWindowsPage = new AlertsFrameWindowsPage();
            this.nestedFramesPage = new NestedFramesPage();
            this.framesPage = new FramesPage();
        }

        [When(@"I click on Alerts, Frame & Windows button")]
        public void WhenIClickOnAlertsFrameWindowsButton()
        {
            mainPage.WaitAndClickAlertsFrameWindowsButton();
        }

        [When(@"I click on Nested Frames button")]
        public void WhenIClickOnNestedFramesButton()
        {
            alertsFrameWindowsPage.WaitAndClickNestedFramesMenuButton();
        }

        [Then(@"Page with Nested Frames form is open")]
        public void ThenPageWithNestedFramesFormIsOpen()
        {
            Assert.IsTrue(nestedFramesPage.IsPageOpen(), "Page is not opened");
        }

        [Then(@"There are messages ""([^""]*)"" and ""([^""]*)"" present on page")]
        public void ThenThereAreMessagesAndPresentOnPage(string p0, string p1)
        {
            nestedFramesPage.SwitchToParentFrame();
            Assert.IsTrue(nestedFramesPage.TextExistsOnPage(p0), $"Text {p0} is not present on page");
            nestedFramesPage.SwitchToChildFrame();
            Assert.IsTrue(nestedFramesPage.TextExistsOnPage(p1), $"Text {p1} is not present on page");
            DriverUtils.SwitchToDefaultContent();
        }

        [When(@"I select Frames option in a left menu")]
        public void WhenISelectFramesOptionInALeftMenu()
        {
            alertsFrameWindowsPage.WaitAndClickFramesMenuButton();
        }

        [Then(@"Page with Frames form is open")]
        public void ThenPageWithFramesFormIsOpen()
        {
            Assert.IsTrue(framesPage.IsPageOpen(), "Frames page is not open");
        }

        [Then(@"Message from upper frame is equal to the message from lower frame")]
        public void ThenMessageFromUpperFrameIsEqualToTheMessageFromLowerFrame()
        {
            Assert.IsTrue(framesPage.AreFramesTextsEqual(), "Frames texts are not equal");
        }
    }
}
