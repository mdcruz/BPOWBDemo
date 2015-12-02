using BPOWBAutomation.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BPOWBAutomation.StepDefinitions.OWB
{
    [Binding]
    public class CreateMarineParcelSteps : WinFeatureBase
    {
        [Given(@"I create New Planned Parcel with (.*)")]
        public void GivenICreateNewPlannedParcelWithSelectedTransport(string transportType)
        {
            OWBViews.ShipmentView
                .ClickNewPlannedParcel()
                .SelectModeOfTransport(transportType);
        }

        [Given(@"I fill in mandatory fields to create planned (.*) with (.*) BBL")]
        public void GivenIFillInMandatoryFieldsToCreatePlannedPurchaseWithBBL(string parcelType, int quantity)
        {
            OWBViews.ShipmentView.FillMandatoryDetailsToCreateParcel(parcelType, quantity);
        }

        [When(@"I create the parcel")]
        public void WhenICreateTheParcel()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the parcel should be created successfully")]
        public void ThenTheParcelShouldBeCreatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
