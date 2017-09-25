using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceGameLib;

namespace DiceGameTests
{
    [TestClass]
    public class Dicegametest
    {
        [TestMethod]
        public void TestMethod1Dicewinner()
        {
            // Arrange
            var obj = new Game();
            //Act
             var  result = obj.ThrowDice(4, 3);
            //Assert
            Assert.AreEqual(7, result);

                
        }
    }
}
