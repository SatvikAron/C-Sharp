using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerServicsLib;

namespace CustomerServicesLibTest
{
    [TestClass]
    public class CustomerServicsTests
    {
        [TestMethod]
        public void CompleteFlow()
        {
            var sut = new CustomerServics();
            var ticketId = sut.EnterTicket("amin@gail.com","Aron",new DateTime(2017,10,1),"My ticket information");
        }

    }
}
