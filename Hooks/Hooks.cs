using Task3_1.Driver;
using TechTalk.SpecFlow;

namespace Task3_1.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            SeleniumDriver.Dispose();
        }
    }
}