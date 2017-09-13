using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestsLib
{
    [TestClass]
    public class StorytellerTests
    {
        [TestMethod]
        public void TellStoryToYoungNotScary()
        {
            var sut = new Storyteller();
            var actual = sut.TellStory("Aron", 6, false);
            Assert.AreEqual($"Lyssna nu Aron. Det var en gång en prinsessa som tyckte om att dansa.", actual);
        }
        [TestMethod]
        public void TellStoryToOldNotScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Linda", 8, false);
            Assert.AreEqual($"Hallå Linda! En gång fanns en kille som tyckte om att dansa.", actual);
        }
        [TestMethod]
        public void TellStoryToOldScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Linda", 8, true);
            Assert.AreEqual($"Hallå Linda! En gång fanns en kille som egentligen var en varulv.", actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TellStoryToYoungScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Peter", 4, true);
        }
    }
}