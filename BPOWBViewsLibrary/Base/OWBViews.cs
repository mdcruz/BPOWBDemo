using BPOWBHelpers;
using BPOWBViewsLibrary.Views;
using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace BPOWBViewsLibrary.Base
{
    public class OWBViews
    {
        private Application application;

        #region Page views
        public LoginView LoginView
        {
            get { return new LoginView(GetWindow(AppConfigHelper.Get("WindowName"))); }
        }

        public MenuBarView MenuBarView
        {
            get { return new MenuBarView(GetWindow(AppConfigHelper.Get("WindowName"))); }
        }

        public ShipmentView ShipmentView
        {
            get { return new ShipmentView(GetWindow(AppConfigHelper.Get("WindowName"))); }
        }

        public DashboardView DashboardView
        {
            get { return new DashboardView(GetWindow(AppConfigHelper.Get("WindowName"))); }
        }
        #endregion

        public void Initialise(Application application)
        {
            this.application = application;
        }

        private Window GetWindow(string windowName)
        {
            return Retry.For(
                () => application.GetWindows().First(x => x.Title.Contains(windowName)), TimeSpan.FromSeconds(30));
        }
    }
}
