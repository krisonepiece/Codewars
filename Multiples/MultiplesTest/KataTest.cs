using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiples;

namespace MultiplesTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = 23;
            var actual = Kata.Solution(10);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expect = 45;
            var actual = Kata.Solution(15);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expect = 60;
            var actual = Kata.Solution(16);
            Assert.AreEqual(expect, actual);
        }
    }
}
