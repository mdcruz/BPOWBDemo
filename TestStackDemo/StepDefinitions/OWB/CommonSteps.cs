using BPOWBAutomation.Features;
using BPOWBViewsLibrary.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [Given(@"I am on the (.*) tab")]
        public void GivenIAmOnTheShipmentsTab(string tabName)
        {
            WinViewBase.MenuBarView.SelectTab(tabName);
            //Assert
        }

    }
}
