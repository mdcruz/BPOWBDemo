using BPOWBViewsLibrary.Base;
using TestStack.White.Configuration;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace BPOWBViewsLibrary.Views
{
    public class DashboardView : WinElementBase
    {
        private ListBox Dashboard
        {
            get { return ListBox(SearchCriteria.ByAutomationId("categoryListBox")); }
        }

        public DashboardView(Window window) : base(window) { }

        public void WaitForDashboard()
        {   
            _window.RightClick();
            WaitUntilVisible(Dashboard, "Dashboard not loaded within specified duration");
        }
    }
}
