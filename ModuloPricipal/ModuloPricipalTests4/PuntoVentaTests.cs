﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModuloPricipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloPricipal.Tests
{
    [TestClass()]
    public class PuntoVentaTests
    {
        [TestMethod()]
        public void PuntoVentaTest()
        {
            Assert.Fail();
            PuntoVenta p = new PuntoVenta();
            p._Eliminar(1);
        }
    }
}