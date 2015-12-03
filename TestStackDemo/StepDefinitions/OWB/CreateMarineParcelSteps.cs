using BPOWBAutomation.Features;
using NSpec;
using TechTalk.SpecFlow;

namespace BPOWBAutomation.StepDefinitions.OWB
{
    [Binding]
    public class CreateMarineParcelSteps : WinFeatureBase
    {
        [Given(@"I create New Planned Parcel with (.*)")]
        public void GivenICreateNewPlannedParcelWithSelectedTransport(string transportType)
        {
            OWBViews.ShipmentView.ClickNewPlannedParcel().SelectModeOfTransport(transportType);
        }

        [Given(@"I fill in mandatory fields to create planned (.*) with (.*) BBL")]
        public void GivenIFillInMandatoryFieldsToCreatePlannedPurchaseWithBBL(string parcelType, double quantity)
        {
            OWBViews.ShipmentView.FillMandatoryDetailsToCreateParcel(parcelType, quantity);
        }

        [When(@"I create the parcel")]
        public void WhenICreateTheParcel()
        {
            OWBViews.ShipmentView.SaveParcel();
        }

        [Then(@"the parcel should be created successfully")]
        public void ThenTheParcelShouldBeCreatedSuccessfully()
        {
            OWBViews.ShipmentView.IsParcelCreatedSuccessfully().should_be_true();
        }

    }
}
