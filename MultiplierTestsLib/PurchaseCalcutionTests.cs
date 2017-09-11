using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestsLib
{
    [TestClass]
    public class PurchaseCalcutionTests
    {
        [TestMethod]
        public void ExcludedVat()
        {
            var sut = new PurchaseCalcution();
            var total = sut.EXecute(10, 100.0M, false);
            Assert.AreEqual(1000.0M,total);
        }
        [TestMethod]
        public void IncludedVat()
        {
            var sut = new PurchaseCalcution();
            var total = sut.EXecute(10, 100.0M, true);
            Assert.AreEqual(1250.0M, total);


        }
    }
}
