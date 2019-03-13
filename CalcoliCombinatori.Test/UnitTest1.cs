using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        public void TestFattoriale(int num, long final_value)
        {
            long fact = EquazioniLibrary.CalcoliCombinatori.Fattoriale(num);
            Assert.AreEqual(final_value, fact);
        }
    }
}
