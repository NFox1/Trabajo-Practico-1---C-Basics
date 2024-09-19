using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsElectrodomestico
{
    [TestClass()]
    public class unitTest_Lavadora
    {
        [TestMethod()]
        public void precioFinalTest_Lavadora_ConIncremento()
        {
            Lavadora lavadora = new Lavadora(1000, 50, 40, 'D', "blanco");
            double resultado = lavadora.precioFinal();
            Assert.AreEqual(1180, resultado);
        }

        [TestMethod()]
        public void precioFinalTest_Lavadora_SinIncremento()
        {
            Lavadora lavadora = new Lavadora(700, 45, 30, 'D', "blanco");
            double resultado = lavadora.precioFinal();
            Assert.AreEqual(800, resultado);
        }

        [TestMethod()]
        public void comprobarColor_Lavadora_CasoTrue()
        {
            Lavadora lavadora = new Lavadora();
            bool resultado = lavadora.comprobarColor("blanco");
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void comprobarColor_Lavadora_CasoFalse()
        {
            Lavadora lavadora = new Lavadora();
            bool resultado = lavadora.comprobarColor("amarillo");
            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void validarConsumoEnergetico_Lavadora_CasoTrue()
        {
            Lavadora lavadora = new Lavadora();
            bool resultado = lavadora.validarConsumoEnergetico('A');
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void validarConsumoEnergetico_Lavadora_CasoFalse()
        {
            Lavadora lavadora = new Lavadora();
            bool resultado = lavadora.validarConsumoEnergetico('G');
            Assert.IsFalse(resultado);
        }
    }

    [TestClass()]
    public class unitTest_Television
    {
        [TestMethod()]
        public void precioFinalTest_Television_ConIncremento()
        {
            Television television = new Television(2000, 10, 50, 'A', "blanco");
            double resultado = television.precioFinal();
            Assert.AreEqual(2743, resultado);
        }

        [TestMethod()]
        public void precioFinalTest_Television_SinIncremento()
        {
            Television television = new Television(1700, 10, 40, 'A', "blanco");
            double resultado = television.precioFinal();
            Assert.AreEqual(1810, resultado);
        }

        [TestMethod()]
        public void comprobarColor_Television_CasoTrue()
        {
            Television television = new Television();
            bool resultado = television.comprobarColor("negro");
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void comprobarColor_Lavadora_CasoFalse()
        {
            Television television = new Television();
            bool resultado = television.comprobarColor("gris");
            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void validarConsumoEnergetico_Lavadora_CasoTrue()
        {
            Television television = new Television();
            bool resultado = television.validarConsumoEnergetico('B');
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void validarConsumoEnergetico_Lavadora_CasoFalse()
        {
            Television television = new Television();
            bool resultado = television.validarConsumoEnergetico('V');
            Assert.IsFalse(resultado);
        }
    }
}