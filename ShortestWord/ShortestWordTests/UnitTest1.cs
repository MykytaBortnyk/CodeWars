using NUnit.Framework;
using ShortestWord;

namespace ShortestWordTests
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
            Assert.AreEqual(3, Program.FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, Program.FindShort("turns out random test cases are easier than writing out basic ones"));
        }
    }
}