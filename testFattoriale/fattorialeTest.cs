using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using classFatt;

namespace testFattoriale
{
    [TestClass]
    public class fattorialeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;

            int risultatoaspettato = classFatt.classFattor.Fattoriale(i);




            Assert.AreEqual(i, risultatoaspettato);

        }
    }
}
