using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Persona;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestsPersona
{
    [TestClass()]
    public class UnitTest_validarSexo
    {
        [TestMethod()]
        public void validarSexoTest_Hombre()
        {
            char sexo = 'H';
            bool resultado = Persona.validarSexo(sexo);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod()]
        public void validarSexoTest_Mujer()
        {
            char sexo = 'M';
            bool resultado = Persona.validarSexo(sexo);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod()]
        public void validarSexoTest_NoBinario()
        {
            char sexo = 'N';
            bool resultado = Persona.validarSexo(sexo);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod()]
        public void validarSexoTest_errordetectado_SinDatos()
        {
            char sexo = 'x';
            bool resultado = Persona.validarSexo(sexo);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod()]
        public void validarSexoTest_errordetectado_CharInvalido()
        {
            char sexo = '0';
            bool resultado = Persona.validarSexo(sexo);
            Assert.AreEqual(false, resultado);
        }        
    }

    [TestClass()]
    public class UnitTest_esMayorDeEdad
    {
        [TestMethod()]
        public void esMayorDeEdadTest_FalsoEnCasoDeMenorDe18()
        {
            Persona persona = new Persona("Julian", 17, 'H');
            bool resultado = persona.esMayorDeEdad();
            Assert.AreEqual(false, resultado);
        }

        [TestMethod()]
        public void esMayorDeEdadTest_FalsoEnCasoDe18()
        {
            Persona persona = new Persona("Vic", 18, 'N');
            bool resultado = persona.esMayorDeEdad();
            Assert.AreEqual(false, resultado);
        }

        [TestMethod()]
        public void esMayorDeEdadTest_VerdaderoEnCasoDeMayorDe18()
        {
            Persona persona = new Persona("Josefina", 19, 'H');
            bool resultado = persona.esMayorDeEdad();
            Assert.AreEqual(true, resultado);
        }
    }

    [TestClass()]
    public class UnitTest_calcularIMC
    {
        [TestMethod()]
        public void calcularIMCTest_CasoMenorDe20()
        {
            Persona persona = new Persona("Alberto", 20, 'H', 60.5, 1.75, 45215930);
            int resultado = persona.calcularIMC();
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod()]
        public void calcularIMCTest_CasoMenorIgualDe25()
        {
            Persona persona = new Persona("Juan", 19, 'H', 75.5, 1.80, 46453198);
            int resultado = persona.calcularIMC();
            Assert.AreEqual(0, resultado);
        }

        [TestMethod()]
        public void calcularIMCTest_CasoMayorDe25()
        {
            Persona persona = new Persona("Enrique", 21, 'H', 80, 1.70, 4389321);
            int resultado = persona.calcularIMC();
            Assert.AreEqual(1, resultado);
        }
    }

    [TestClass()]
    public class UnitTest_toString
    {
        [TestMethod()]
        public void toStringTest()
        {
            Persona persona = new Persona("Jorge", 30, 'H', 80, 1.85, 39548912);
            string resultado = persona.toString();
            Assert.AreEqual("\nEl nombre es: Jorge \nSu edad es: 30 años\nSu sexo es: Hombre \nSu peso es: 80 KG\nSu altura es: 1,85 M\nSu DNI es: 39548912", resultado);
        }
    }
}