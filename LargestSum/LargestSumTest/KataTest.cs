using System;
using LargestSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargestSumTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = 0;
            var actual = Kata.LargestSum(new[] { -1, -2, -3 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expect = 0;
            var actual = Kata.LargestSum(new int[0]);
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expect = 10;
            var actual = Kata.LargestSum(new[] { 1, 2, 3, 4 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var expect = 187;
            var actual = Kata.LargestSum(new[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 });
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var expect = 5000;
            var actual = Kata.LargestSum(new[] { 100, 200, 300, -1000, 5000 });
            Assert.AreEqual(expect, actual);
        }
    }
}
