using BPOWBAutomation.Features;
using BPOWBViewsLibrary.Base;
using TechTalk.SpecFlow;

namespace BPOWBAutomation.StepDefinitions.OWB
{
    [Binding]
    public class CommonSteps : WinFeatureBase
    {
        [Given(@"I am logged in to OWB application")]
        public void GivenIAmLoggedInToOWBApplication()
        {
            WinViewBase.LoginView.Login();
        }

    }
}
