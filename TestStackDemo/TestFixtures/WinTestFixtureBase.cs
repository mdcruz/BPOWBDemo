using BPOWBViewsLibrary.Base;
using System.Diagnostics;
using System.IO;
using TestStack.White;

namespace BPOWBAutomation.TestFixtures
{
    public class WinTestFixtureBase
    {
        protected Application CurrentApplication { get; set; }
        protected WinViewBase WinViewBase { get; set; }

        public void TestSetup(string filePath)
        {
            ProcessStartInfo process = new ProcessStartInfo(filePath);
            process.WorkingDirectory = Path.GetDirectoryName(filePath);

            CurrentApplication = Application.AttachOrLaunch(process);

            WinViewBase = new WinViewBase();
            WinViewBase.Initialise(CurrentApplication);
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
