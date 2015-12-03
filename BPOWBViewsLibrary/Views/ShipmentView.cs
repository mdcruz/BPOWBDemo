using BPOWBViewsLibrary.Base;
using BPOWBViewsLibrary.Model;
using System;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace BPOWBViewsLibrary.Views
{
    public class ShipmentView : WinElementBase
    {
        #region Elements
        private MenuBar CreateParcelBtn
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

        private Button SaveParcelBtn
        {
            get { return Button(SearchCriteria.ByAutomationId("btnSaveDirty")); }
        }

        private ListBox NotificationMsg
        {
            get { return ListBox(SearchCriteria.ByAutomationId("GvErrors")); }
        }

        private Label ShipmentNumber
        {
            get { return Label(SearchCriteria.ByAutomationId("ShipmentNumber")); }
        }

        private Label ParcelSeqNumber
        {
            get { return Label(SearchCriteria.ByAutomationId("ParcelSeqNumber")); }
        }
        #endregion

        public ShipmentView(Window window) : base(window) { }

        public ShipmentView ClickNewPlannedParcel()
        {
            WaitUntilVisible(CreateParcelBtn);
            CreateParcelBtn.Click();

            return this;
        }

        public ShipmentView SelectModeOfTransport(string transportName)
        {
            Button selectedVessel = Button(SearchCriteria.ByText(transportName));
            selectedVessel.Click();
           
            return this;
        }

        public void FillMandatoryDetailsToCreateParcel(string parcelType, double quantity)
        {
            AutomationElement childElementParcel = GetChildElement(ParcelCbx, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.EditableTxtBox));
            TextBox parcelTxtbox = new TextBox(childElementParcel, new NullActionListener());
            parcelTxtbox.SetValue(parcelType);

            Quantity.SetValue(quantity);

            AutomationElement childElementQuantity = GetChildElement(QuantityCbx, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.EditableTxtBox));
            TextBox quantityTxtbox = new TextBox(childElementQuantity, new NullActionListener());
            quantityTxtbox.SetValue("BBL");

            AutomationElement childElementPlannedDatesFrom = GetChildElement(PlannedDateFrom, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.TimeInputTxtBox));
            TextBox plannedDatesFromTxtbox = new TextBox(childElementPlannedDatesFrom, new NullActionListener());
            plannedDatesFromTxtbox.SetValue(DateTime.Now.ToString("dd-MMM-yyyy"));

            AutomationElement childElementPlannedDatesTo = GetChildElement(PlannedDateTo, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.TimeInputTxtBox));
            TextBox plannedDatesToTxtbox = new TextBox(childElementPlannedDatesTo, new NullActionListener());
            plannedDatesToTxtbox.SetValue(DateTime.Now.AddDays(30).ToString("dd-MMM-yyyy"));
        }

        public void SaveParcel()
        {
            WaitUntilEnabled(SaveParcelBtn);
            SaveParcelBtn.Click();
        }

        public bool IsParcelCreatedSuccessfully()
        {
            AutomationElement childElementNotification = GetChildElement(NotificationMsg, new PropertyCondition(AutomationElement.AutomationIdProperty, ElementProperties.NotificationMessage));
            Label parcelSuccessfulLabel = new Label(childElementNotification, new NullActionListener());

            var shipmentNum = ShipmentNumber.Text.Substring(12).TrimEnd();
            var seqNum = ParcelSeqNumber.Text[0];
            var actualTxt = "Parcel '" + seqNum + "' for shipment '" + shipmentNum + "' created successfully.";

            return (parcelSuccessfulLabel.Text.Equals(actualTxt)) ? true : false;
        }
    }
}
