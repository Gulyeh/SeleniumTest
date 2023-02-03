using NUnit.Framework;
using Task3_1.Pages;
using Task3_1.Utils;
using TechTalk.SpecFlow;

namespace Task3_1.Steps
{
    [Binding]
    public class HandlesStepDefinitions
    {
        private readonly AlertsFrameWindowsPage alertsFrameWindowsPage;
        private readonly BrowserWindowsPage browserWindowsPage;
        private readonly ElementsPage elementsPage;
        private readonly LinksPage linksPage;
        private readonly MainPage mainPage;
        private readonly SamplePage samplePage;

        public HandlesStepDefinitions()
        {
            this.alertsFrameWindowsPage = new AlertsFrameWindowsPage();
            this.browserWindowsPage = new BrowserWindowsPage();
            this.elementsPage = new ElementsPage();
            this.linksPage = new LinksPage();
            this.mainPage = new MainPage();
            this.samplePage = new SamplePage();
        }

        [When(@"I click on Browser Windows in the menu")]
        public void WhenIClickOnBrowserWindowsInTheMenu()
        {
            alertsFrameWindowsPage.WaitAndClickBrowserWindows();
        }

        [Then(@"Page with Browser Windows form is open")]
        public void ThenPageWithBrowserWindowsFormIsOpen()
        {
            DriverUtils.SwitchTab(0);
            Assert.IsTrue(browserWindowsPage.IsPageOpen(), "Browser Windows page is not open");
        }

        [When(@"I click on New Tab button")]
        public void WhenIClickOnNewTabButton()
        {
            browserWindowsPage.WaitAndClickNewTabButton();
        }

        [Then(@"New tab with sample page is open")]
        public void ThenNewTabWithSamplePageIsOpen()
        {
            DriverUtils.SwitchTab(1);
            Assert.IsTrue(samplePage.IsPageOpen(), "Sample page is not open");
        }

        [When(@"I close current tab")]
        public void WhenICloseCurrentTab()
        {
            DriverUtils.CloseCurrentTab();
        }

        [When(@"I click Elements button in the menu")]
        public void WhenIClickElementsButtonInTheMenu()
        {
            elementsPage.WaitAndClickElementsButton();
        }

        [When(@"I click Links button in the menu")]
        public void WhenIClickLinksButtonInTheMenu()
        {
            elementsPage.WaitAndClickLinksButton();
        }

        [Then(@"Page with Links form is open")]
        public void ThenPageWithLinksFormIsOpen()
        {
            Assert.IsTrue(linksPage.IsPageOpen(), "Links page is not open");
        }

        [When(@"I click on Home link")]
        public void WhenIClickOnHomeLink()
        {
            linksPage.WaitAndClickHomeLink();
        }

        [Then(@"(.*) Tabs are open")]
        public void ThenTabsAreOpen(int p0)
        {
            Assert.IsTrue(DriverUtils.GetCurrentTabsCount() == p0, "New tab is not open");
        }

        [When(@"I switch to tab with index (.*)")]
        public void WhenISwitchToTabWithIndex(int p0)
        {
            DriverUtils.SwitchTab(p0);
        }

        [Then(@"Main Page is open")]
        public void ThenMainPageIsOpen()
        {
            Assert.IsTrue(mainPage.IsPageOpen(), "Main page is not open");
        }


        [When(@"I resume to previous tab")]
        public void WhenIResumeToPreviousTab()
        {
            DriverUtils.SwitchTab(0);
        }
    }
}
