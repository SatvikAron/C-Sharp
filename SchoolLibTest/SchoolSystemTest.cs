using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolLibTest
{
    [TestClass]
    public class SchoolSystemTest
    {
        [TestMethod]
        public void Count()
        {
            var sut = new SchoolSystem();
            sut.AddClass("Spo16",20);
            sut.AddClass("Dpo16", 20);
            sut.AddClass("Dpo16", 20);







            Assert.AreEqual(2,sut.ClassCount);
            Assert.AreEqual(60, sut.StudentCount);

        }
    }
}
