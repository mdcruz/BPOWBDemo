using BPOWBViewsLibrary.Base;
using System.Threading;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace BPOWBViewsLibrary.Views
{
    public class DashboardView : WinElementBase
    {
        private ListItem DashboardListItem
        {
            get { return ListItem(SearchCriteria.ByText("BP.OWB.Dashboard.Utility.NotificationCategory")); }
        }

        public DashboardView(Window window) : base(window) { }

        public void WaitForDashboard()
        {
            Thread.Sleep(5000);
            _window.RightClick();
            WaitUntilVisible(DashboardListItem);
        }
    }
}
