using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeLib;

namespace PracticeTestLib
{
    [TestClass]
    public class PersoninformationTest
    {
        [TestMethod]
        public void GetInformationTest()
        {
            var sut = new Personinformation();
            var telephoneno = "070-6186120";
            var name = "Mattias Asplund";
            var dateofbirth = "1971-04-05";

            sut.EnterDetails(dateofbirth, name, telephoneno);
            var expected = "1971-04-05;Mattias Asplund;070-6186120";
            Assert.AreEqual(expected, sut.Greeting);

        }
    }
}
