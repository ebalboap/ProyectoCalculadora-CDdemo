using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProyectoCalculadora.Controllers;

namespace NUnit_ProyectoCalculadora
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestDivision()
        {
            var resultado = new Calculadora();
            var dato= resultado.Division(4, 4);
            Assert.AreEqual(1, dato);
        }
    }
}
