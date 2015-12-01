using BPOWBAutomation.TestFixtures;
using BPOWBHelpers;
using System.Linq;
using TechTalk.SpecFlow;

namespace BPOWBAutomation.Features
{
    public class WinFeatureBase : WinTestFixtureBase
    {
        [BeforeScenario("OWB")]
        public void BeforeScenario()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("Manual")) return;
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("Pending")) return;

            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("OWB"))
            {
                TestSetup(AppConfigHelper.Get("OWBFilePath"));
            }
            
        }

        [AfterScenario("OWB")]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("Manual")) return;
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains<string>("Pending")) return;

            TestTeardown();
        }
    }
}
