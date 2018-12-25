using System;
using HighestRank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HighestRankTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = 12;
            var actual = Kata.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expect = 12;
            var actual = Kata.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expect = 3;
            var actual = Kata.HighestRank(new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 });
            Assert.AreEqual(expect, actual);
        }
    }
}
