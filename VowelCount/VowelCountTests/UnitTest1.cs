using NUnit.Framework;
using VowelCount;

namespace VowelCountTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, Program.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}