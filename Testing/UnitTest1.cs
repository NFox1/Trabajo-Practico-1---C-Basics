using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Persona;

namespace Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void validarSexoTest()
        {
            char sexo = 'H';
            bool resultado = Persona.validarSexo(sexo);
            Assert.AreEqual(true, resultado);
        }
    }
}