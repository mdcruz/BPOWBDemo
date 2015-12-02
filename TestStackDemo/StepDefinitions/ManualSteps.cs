using TechTalk.SpecFlow;

/**
 * Description: A way to ignore executing the scenarios marked with @manual
 *              tag but the SpecFlow tracing will still display the steps,
 *              so the manual scenarios can be checked based on the report
 * */

namespace BPOWBAutomation.StepDefinitions
{
    //[Binding, Scope(Tag = "Manual")]
    public class ManualSteps
    {
        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep() { ScenarioContext.Current.Pending(); }

        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep(string multiLineStringParam) { ScenarioContext.Current.Pending(); }

        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep(Table tableParam) { ScenarioContext.Current.Pending(); }
    }
}
