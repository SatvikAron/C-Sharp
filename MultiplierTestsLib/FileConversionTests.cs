using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestsLib
{
    [TestClass]
    public class FileConversionTests
    {
        [TestMethod]
        public void Jahurul_Aron1983()
        {
            FileConverter sut = new FileConverter();
            //var sut = new FileConverter();
            string actual = sut.Transfer("jahurul;aron; 1983");
            Assert.AreEqual("JAHURUL ARON 34 ÅR GAMMAL", actual);
        }
    }
}
