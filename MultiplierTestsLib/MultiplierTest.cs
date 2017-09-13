using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestsLib
{
    [TestClass]
    public class MultiplierTest
    {
        [TestMethod]
        public void Simple()
        {
            MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
            // 
            var actual = myMultiplier.Simple(20, 20);
            Assert.AreEqual(400, actual);
        }
        [TestMethod]
        public void While()
        {
            //arrange
            MultiplierLib.Multiplier myMultiplier = new MultiplierLib.Multiplier();
            // act
            var actual = myMultiplier.While(20, 20);
            //assert
            Assert.AreEqual(400, actual);
        }
    }
}
