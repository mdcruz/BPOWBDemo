using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Configuration;
using TestStack.White;
using System.IO;
using BPOWBHelpers;
using System.Text;

namespace BPOWBAutomation
{
    [TestClass]
    public class Class2
    {
        [TestMethod]
        public void Can_Login()
        {
            string OWBPath = AppConfigHelper.Get("OWBFilePath");
            ProcessStartInfo p = new ProcessStartInfo(OWBPath.ToString());
            p.WorkingDirectory = Path.GetDirectoryName(OWBPath.ToString());

            Application app = Application.AttachOrLaunch(p);
            Assert.IsNotNull(app);
            var owb = new Class1(app);
            owb.Login();
            bool dashboard = owb.isOnDashboard("tabControl");
            Assert.IsTrue(dashboard);

        }
    }
}

