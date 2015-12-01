using BPOWBViewsLibrary.Base;
using BPOWBViewsLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.WindowItems;

namespace BPOWBViewsLibrary.Views
{
    public class MenuBarView : WinElementBase
    {
        private Tab MainTab
        {
            get { return Tab(SearchCriteria.ByAutomationId("tabControl")); }
        }
        public MenuBarView(Window window) : base(window) { }

        public void SelectTab(string tabName)
        {
            if (tabName.Equals("Dashboard"))
            {
                MainTab.SelectTabPage((int)Enums.TabNames.Dashboard);
            }

            else if (tabName.Equals("Deals"))
            {
                MainTab.SelectTabPage((int)Enums.TabNames.Deals);
            }

            else if (tabName.Equals("Shipments"))
            {
                MainTab.SelectTabPage((int)Enums.TabNames.Shipments);
            }

            else if (tabName.Equals("Parcels"))
            {
                MainTab.SelectTabPage((int)Enums.TabNames.Parcels);
            }

            else
            {
                throw new ArgumentException("Tab name provided not valid");
            }

        }
    }
}
