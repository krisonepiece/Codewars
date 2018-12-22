using System;
using CarParkEscape;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarParkEscapeTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = new string[] { "L4", "D1", "R4" };
            var actual = new Kata().escape(new int[,] {   { 1, 0, 0, 0, 2 }, 
                                                    { 0, 0, 0, 0, 0 }});
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var expect = new string[] { "R3", "D2", "R1" };
            var actual = new Kata().escape(new int[,] {   { 2, 0, 0, 1, 0 },
                                                    { 0, 0, 0, 1, 0 },
                                                    { 0, 0, 0, 0, 0 }});
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var expect = new string[] { "R3", "D3" };
            var actual = new Kata().escape(new int[,] {   { 0, 2, 0, 0, 1 },
                                                    { 0, 0, 0, 0, 1 },
                                                    { 0, 0, 0, 0, 1 },
                                                    { 0, 0, 0, 0, 0 }});
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var expect = new string[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
            var actual = new Kata().escape(new int[,] {   { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 1 },
                                          { 1, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 }});
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var expect = new string[] { };
            var actual = new Kata().escape(new int[,] { { 0, 0, 0, 0, 2 } });
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}
