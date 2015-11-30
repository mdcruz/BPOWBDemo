using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;



using System.Threading;
using NUnit.Framework;

namespace TestStackDemo
{
    [TestClass]
    public class Class2
    {
        [TestMethod]
        public void Can_Login()
        {
            ProcessStartInfo p = new ProcessStartInfo(@"C:\owb\OWB\Main\Source\Owb\BP.OWB.Container\bin\Debug\Bp.Owb.Desktop.exe");
            p.WorkingDirectory = @"C:\owb\OWB\Main\Source\Owb\BP.OWB.Container\bin\Debug";
            Application app = Application.AttachOrLaunch(p);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(app);
            var owb = new Class1(app);
            owb.Login();
            bool dashboard = owb.isOnDashboard("tabControl");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(dashboard);

        }
    }
}

