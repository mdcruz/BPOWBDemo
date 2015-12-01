using BPOWBViewsLibrary.Views;
using System;
using System.Linq;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Utility;

namespace BPOWBViewsLibrary.Base
{
    public class WinViewBase
    {
        private Application application;

        public LoginView LoginView
        {
            get { return new LoginView(GetWindow("Operators WorkBench")); }
        }

        public void Initialise(Application application)
        {
            this.application = application;
        }

        private Window GetWindow(string windowName)
        {
            return Retry.For(
                () => application.GetWindows().First(x => x.Title.Contains(windowName)), TimeSpan.FromSeconds(20));
        }
    }
}
