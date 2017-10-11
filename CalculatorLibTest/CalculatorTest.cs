using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;
using System.Diagnostics;

namespace CalculatorLibTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void EmptyDisplay()
        {
            //Arrange
            Calculator sut = new Calculator();
            //Act
            sut.Poweron();
            //Assert
            Assert.AreEqual(0,sut.Display);
        }
        [TestMethod]
        public void OneDigitDisplay()
        {
            //Arrange
            Calculator sut = new Calculator();
            //Act
                sut.Press("7");
            //Assert
            Assert.AreEqual(7, sut.Display);
        }
        [TestMethod]
        public void TwoDigitDisplay()
        {
            //Arrange
            Calculator sut = new Calculator();
            //Act
            sut.Press("2");
            sut.Press("5");
            //Assert
            Assert.AreEqual(25, sut.Display);
        }
        [TestMethod]
        public void Add12and37()
        {
            //Arrange
            Calculator sut = new Calculator();
            //Act
            sut.Press("1");
           
            sut.Press("2");
            Debug.WriteLine(sut.Display);

            sut.Press("+");
           

            sut.Press("2");
           

            sut.Press("5");
           

            sut.Press("=");
            








            //Assert
            Assert.AreEqual(37, sut.Display);
            Debug.WriteLine(sut.Display);

        }
    }
}
