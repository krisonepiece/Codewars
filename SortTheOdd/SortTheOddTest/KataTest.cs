using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortTheOdd;

namespace SortTheOddTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = new int[] { 1, 3, 2, 8, 5, 4 };
            var actual = Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 });
            CollectionAssert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expect = new int[] { 1, 3, 2, 8, 5, 4 };
            var actual = Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 });
            CollectionAssert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expect = new int[] { };
            var actual = Kata.SortArray(new int[] { });
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}
