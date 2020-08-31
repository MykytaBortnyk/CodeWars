using NUnit.Framework;
using TwoToOne;

namespace TwoToOneTests
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
            Assert.AreEqual("aehrsty", Program.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", Program.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", Program.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}