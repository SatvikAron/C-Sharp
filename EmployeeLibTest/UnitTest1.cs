using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace EmployeeLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RegexTest()
        {

            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120 ";


            EmployeeConverter sut = new EmployeeConverter();
            var results = sut.Convert(input);


        }
    }
}
