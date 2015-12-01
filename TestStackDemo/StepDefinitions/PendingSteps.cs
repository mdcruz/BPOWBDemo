using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

/**
 * Description: A way to mark tests as pending implementation
 *              but show up in report
 * */

namespace BPOWBAutomation.StepDefinitions
{
    [Binding, Scope(Tag = "Pending")]
    public class PendingSteps
    {
        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep() { ScenarioContext.Current.Pending(); }

        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep(string multiLineStringParam) { ScenarioContext.Current.Pending(); }

        [Given(".*"), When(".*"), Then(".*")]
        public void EmptyStep(Table tableParam) { ScenarioContext.Current.Pending(); }
    }
}
