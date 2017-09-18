using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CirkusLib;

namespace CirkusTestLib
{
    [TestClass]
    public class CirkusTest
    {
        [TestMethod]
        public void CirkusNameTest()
        {
            //Arrange
            Cirkus sut = new Cirkus("Elefantet");
            Artist clown = new Artist("Clownen SursKratt");
            Artist lindansare = new Artist("Lindansaren Repo");
            sut.Anställ(clown);
            sut.Anställ(lindansare);
            sut.ArtistUppträdande(lindansare);
            sut.ArtistUppträdande(lindansare);

            var expected = "Cirkus Elefantet har 2 artister.";

                //Act
            string actual = sut.ToString();
            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
