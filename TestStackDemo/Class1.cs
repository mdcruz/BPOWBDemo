﻿using System.Threading;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace BPOWBAutomation
{
    class Class1
    {
        private Window _window;

        public Class1(Application app)
        {
            //_window = app.GetWindow("Operators WorkBench");
            _window = app.GetWindow("Operators WorkBench");
        }
        public void Login()
        {
            _window.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName")).SetValue("guest2");
            _window.Get<TextBox>(SearchCriteria.ByAutomationId("txtOldPassword")).SetValue("guest");
            _window.Get<Button>(SearchCriteria.ByText("Login")).Click();
            //_window.WaitWhileBusy();
            Thread.Sleep(20000);
        }

        public bool isOnDashboard(string v)
        {
            // _window.WaitWhileBusy();
            // _window.ReloadIfCached();
            //_window.Get<Tab>(SearchCriteria.ByText("Bp.Owb.Desktop.Utility.AppMenuBarTab")).DoubleClick();
            _window.RightClick();
            bool val = _window.Exists<Button>(SearchCriteria.ByText("Show"));
            _window.Get<TextBox>(SearchCriteria.ByAutomationId("Text")).SetValue("Sam");
            _window.Get<Button>(SearchCriteria.ByText("Show")).Click();
            return val;
        }
    }
}
