using BPOWBViewsLibrary.Base;
using BPOWBViewsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace BPOWBViewsLibrary.Views
{
    public class ShipmentView : WinElementBase
    {
        private MenuBar CreateParcel
        {
            get { return MenuBar(SearchCriteria.ByAutomationId("btnNewPlanned")); }
        }

        private ComboBox ParcelCbx
        {
            get { return ComboBox(SearchCriteria.ByAutomationId("CmbParcelType")); }
        }

        private ComboBox QuantityCbx
        {
            get { return ComboBox(SearchCriteria.ByAutomationId("QuantityType")); }
        }

        private UIItem PlannedDateFrom
        {
            get { return UIItem(SearchCriteria.ByAutomationId("PlannedDatesFrom"));  }
        }
        private UIItem PlannedDateTo
        {
            get { return UIItem(SearchCriteria.ByAutomationId("PlannedDatesTo")); }
        }

        private TextBox Quantity
        {
            get { return TextBox(SearchCriteria.ByAutomationId("TxtStdVol")); }
        }

        public ShipmentView(Window window) : base(window) { }

        public ShipmentView ClickNewPlannedParcel()
        {
            WaitUntilVisible(CreateParcel);
            CreateParcel.Click();

            return this;
        }

        public ShipmentView SelectModeOfTransport(string transportName)
        {
            Button selectedVessel = Button(SearchCriteria.ByText(transportName));
            selectedVessel.Click();
           
            return this;
        }

        public void FillMandatoryDetailsToCreateParcel(string parcelType, int quantity)
        {
            AutomationElement childElementParcel = GetChildElement(ParcelCbx, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.EditableTxtBox));
            TextBox parcelTxtbox = new TextBox(childElementParcel, new NullActionListener());
            parcelTxtbox.SetValue(parcelType);

            Quantity.SetValue(quantity);

            AutomationElement childElementQuantity = GetChildElement(QuantityCbx, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.EditableTxtBox));
            TextBox quantityTxtbox = new TextBox(childElementQuantity, new NullActionListener());
            quantityTxtbox.SetValue("BBL");

            AutomationElement childElementPlannedDatesFrom = GetChildElement(PlannedDateFrom, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.TimeInputTxtBox));
            Label plannedDatesFromLabel = new Label(childElementPlannedDatesFrom, new NullActionListener());
            plannedDatesFromLabel.SetValue(DateTime.Now.ToString("dd-MMM-yyyy"));

            AutomationElement childElementPlannedDatesTo = GetChildElement(PlannedDateTo, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.TimeInputTxtBox));
            Label plannedDatesToLabel = new Label(childElementPlannedDatesTo, new NullActionListener());

            //ADD 30 days
            plannedDatesToLabel.SetValue(DateTime.Now.ToString("dd-MMM-yyyy"));
        }
    }
}
