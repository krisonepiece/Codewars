using System;
using System.Collections.Generic;
using FindMissing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMissingTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = 7;
            var actual = Kata.FindMissing(new List<int> { 1, 3, 5, 9, 11 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expect = 15;
            var actual = Kata.FindMissing(new List<int> { 0, 5, 10, 20, 25 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expect = 10;
            var actual = Kata.FindMissing(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var expect = 1400;
            var actual = Kata.FindMissing(new List<int> { 1040, 1220, 1580 });
            Assert.AreEqual(expect, actual);
        }
    }
}
