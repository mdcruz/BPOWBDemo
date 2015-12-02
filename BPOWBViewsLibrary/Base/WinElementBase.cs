using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.TableItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WindowStripControls;

namespace BPOWBViewsLibrary.Base
{
    public class WinElementBase
    {
        protected Window _window;

        public WinElementBase(Window window)
        {
            _window = window;
        }

        #region Win Elements
        protected Button Button(SearchCriteria criteria)
        {
            return _window.Get<Button>(criteria);
        }

        protected TextBox TextBox(SearchCriteria criteria)
        {
            return _window.Get<TextBox>(criteria);
        }

        protected Tab Tab(SearchCriteria criteria)
        {
            return _window.Get<Tab>(criteria);
        }

        protected MenuBar MenuBar(SearchCriteria criteria)
        {
            return _window.Get<MenuBar>(criteria);
        }

        protected ListItem ListItem(SearchCriteria criteria)
        {
            return _window.Get<ListItem>(criteria);
        }

        protected ComboBox ComboBox(SearchCriteria criteria)
        {
            return _window.Get<ComboBox>(criteria);
        }

        #endregion

        #region Explicit waits
        protected void WaitUntilEnabled(UIItem element, string message = "", int maxDuration = 60)
        {
            int maxWait = (maxDuration * 1000);
            int retryInterval = 500;

            while (maxWait > 0)
            {
                if (element.Enabled) { return; }

                Thread.Sleep(retryInterval);
                maxWait -= retryInterval;
            }

            throw new AssertionException((message.Trim().Length > 0) ? message : element.Name);
        }

        protected void WaitUntilVisible(UIItem element, string message = "", int maxDuration = 100)
        {
            int maxWait = (maxDuration * 1000);
            int retryInterval = 500;

            while (maxWait > 0)
            {
                if (element.Visible) { return; }

                Thread.Sleep(retryInterval);
                maxWait -= retryInterval;
            }

            throw new AssertionException((message.Trim().Length > 0) ? message : element.Name);
        }

        protected void WaitUntilNotVisible(UIItem element, string message = "", int maxDuration = 60)
        {
            int maxWait = (maxDuration * 1000);
            int retryInterval = 500;

            while (maxWait > 0)
            {
                if (!element.Visible) { return; }

                Thread.Sleep(retryInterval);
                maxWait -= retryInterval;
            }

            throw new AssertionException((message.Trim().Length > 0) ? message : element.Name);
        }
        #endregion

        #region Child Element(s)
        public AutomationElement GetChildElement(UIItem element, Condition condition)
        {
            AutomationElement childElement = element.AutomationElement.FindFirst(TreeScope.Descendants, condition);
            return childElement;
        }
        #endregion
    }
}
