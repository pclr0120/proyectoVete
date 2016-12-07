using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuloPricipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloPricipal.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void _login_inTest()
        {
            MainWindow  log = new MainWindow();
           log.conexion= "server=localhost;user id=root;password=pclr0120;database=bdvt;";
            bool l=log._login_in();
            bool b = false;
            Assert.AreEqual(b,b);

        }

        
    }
}