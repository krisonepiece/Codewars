using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PascalTriangle;

namespace PascalTriangleTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = new int[] { 1 };
            var actual = Kata.PascalsTriangle(1);
            CollectionAssert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expect = new int[] { 1, 1, 1 };
            var actual = Kata.PascalsTriangle(2);
            CollectionAssert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expect = new int[] { 1, 1, 1, 1, 2, 1 };
            var actual = Kata.PascalsTriangle(3);
            CollectionAssert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var expect = new int[] { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 };
            var actual = Kata.PascalsTriangle(4);
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}
