using NUnit.Framework;
using Task3_1.Pages;
using Task3_1.Utils;
using TechTalk.SpecFlow;

namespace Task3_1.Steps
{
    [Binding]
    public class AlertsStepDefinitions
    {
        private readonly AlertsPage alertsPage;
        private readonly AlertsFrameWindowsPage alertsFrameWindowsPage;
        private readonly ScenarioContext scenarioContext;

        public AlertsStepDefinitions(ScenarioContext scenarioContext)
        {
            this.alertsPage = new AlertsPage();
            this.alertsFrameWindowsPage = new AlertsFrameWindowsPage();
            this.scenarioContext = scenarioContext;
        }

        [When(@"I click on Alerts button")]
        public void WhenIClickOnAlertsButton()
        {
            alertsFrameWindowsPage.WaitAndClickAlertsMenuButton();
        }

        [Then(@"Alerts form page has appeared")]
        public void ThenAlertsFormPageHasAppeared()
        {
            Assert.IsTrue(alertsPage.IsPageOpen(), "Page is not open");
        }

        [When(@"I click on Click Button to see alert button")]
        public void WhenIClickOnClickButtonToSeeAlertButton()
        {
            alertsPage.WaitAndClickAlertButton();
        }

        [Then(@"Alert with text ""([^""]*)"" is open")]
        public void ThenAlertWithTextIsOpen(string p0)
        {
            WaitConditionals.WaitFor(x => AlertUtils.AlertIsPresent());
            Assert.IsTrue(AlertUtils.AlertTextEqualsText(p0), "Alert with text is not open");
        }

        [When(@"I click OK button")]
        public void WhenIClickOKButton()
        {
            AlertUtils.AcceptAlert();
        }

        [Then(@"Alert has closed")]
        public void ThenAlertHasClosed()
        {
            Assert.IsFalse(AlertUtils.AlertIsPresent(), "Alert has not closed");
        }

        [When(@"I click on On button click, confirm box will appear button")]
        public void WhenIClickOnOnButtonClickConfirmBoxWillAppearButton()
        {
            alertsPage.WaitAndClickConfirmBoxButton();
        }

        [When(@"I click on On button click, prompt box will appear button")]
        public void WhenIClickOnOnButtonClickPromptBoxWillAppearButton()
        {
            alertsPage.WaitAndClickPromptAlertButton();
        }


        [When(@"I generate random string and save as ""([^""]*)""")]
        public void WhenIGenerateRandomStringAndSaveAs(string randomString)
        {
            scenarioContext[randomString] = RandomUtils.GenerateRandomString(10);
        }

        [When(@"I enter randomly generated text saved as ""([^""]*)""")]
        public void WhenIEnterRandomlyGeneratedTextSavedAs(string randomString)
        {
            var text = scenarioContext[randomString].ToString();
            AlertUtils.EnterTextIntoPrompt(text);
        }


        [Then(@"Appeared text equals saved text as ""([^""]*)""")]
        public void ThenAppearedTextEqualsSavedTextAs(string radnomString)
        {
            var text = scenarioContext[radnomString].ToString();
            Assert.IsTrue(alertsPage.TextExistsOnPage(text), "Texts are not equal");
        }

    }
}
