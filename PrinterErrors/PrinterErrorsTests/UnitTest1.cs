using System;
using NUnit.Framework;
using PrinterErrors;

namespace PrinterErrorsTests
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
            Console.WriteLine("Testing PrinterError");
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", Program.PrinterError(s));
        }
    }
}