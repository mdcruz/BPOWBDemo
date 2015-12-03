using BPOWBViewsLibrary.Base;
using System.Diagnostics;
using System.IO;
using TestStack.White;
using TestStack.White.Configuration;

namespace BPOWBAutomation.TestFixtures
{
    public class WinTestFixtureBase
    {
        protected Application CurrentApplication { get; set; }
        protected OWBViews OWBViews { get; set; }

        public void TestSetup(string filePath)
        {
            CoreAppXmlConfiguration.Instance.BusyTimeout = 60000;

            ProcessStartInfo process = new ProcessStartInfo(filePath);
            process.WorkingDirectory = Path.GetDirectoryName(filePath);

            CurrentApplication = Application.AttachOrLaunch(process);

            OWBViews = new OWBViews();
            OWBViews.Initialise(CurrentApplication);
        }

        public void TestTeardown()
        {
            if(CurrentApplication != null)
            {
                CurrentApplication.Close();
                CurrentApplication.Dispose();
            }
        }
    }
}
