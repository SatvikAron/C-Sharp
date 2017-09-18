using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VaruKorgLib;

namespace VarukorgTestLib
{
    [TestClass]
    public class VarukorgTests
    {
        [TestMethod]
        public void Orderbekräftelse()
        {
            // Arrange
            Kund testKund = new Kund ({"Test"} ,{ "Testsson"});
            Product testLaptop = new Product("Laptop test");
            testLaptop.Pris = 4000;
            Product testSkärm = new Product("Skärm test");
            testSkärm.Pris = 1500;
            VaruKorg sut = new VaruKorg();
            sut.kund = testKund;
            sut.LäggTillProdukt(testLaptop);
            sut.LäggTillProdukt(testSkärm);
            var expected = "Test Testsson har beställt varor för 5500 kr";

            // Act
            sut.Beställ();
            Orderbekräftelse result = sut.Orderbekräftelse;
            string actual = result.Meddelande;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
