using BPOWBViewsLibrary.Base;
using BPOWBViewsLibrary.Model;
using System.Threading;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace BPOWBViewsLibrary.Views
{
    public class LoginView : WinElementBase
    {
        #region Elements
        private Button LoginBtn
        {
            get { return Button(SearchCriteria.ByText("Login")); }
        }

        private TextBox UsernameField
        {
            get { return TextBox(SearchCriteria.ByAutomationId("txtUserName")); }
        }

        private TextBox PasswordField
        {
            get { return TextBox(SearchCriteria.ByAutomationId("txtOldPassword")); }
        }

        #endregion

        public LoginView(Window window) : base(window) { }

        public void Login()
        {
            User defaultUser = User.GetDefaultCredentials();

            UsernameField.SetValue(defaultUser.Username);
            PasswordField.SetValue(defaultUser.Password);

            Thread.Sleep(500);
            LoginBtn.Click();
            WaitUntilNotVisible(LoginBtn);
        }

    }
}
