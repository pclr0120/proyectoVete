using Microsoft.VisualStudio.TestTools.UnitTesting;
using VeterinariaClientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaClientes.Tests
{
    [TestClass()]
    public class DbConexionTests
    {
        [TestMethod()]
        public void DbConexionTest()
        {
            
        }

        [TestMethod()]
        public void AbrirTest()
        {
            DbConexion sesultado = new DbConexion("localhost","root","toor","bdvt");
            bool esperado = true;
            bool resultado = sesultado.Abrir();
            
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CerrarTest()
        {
            Assert.Fail();
        }
    }
}