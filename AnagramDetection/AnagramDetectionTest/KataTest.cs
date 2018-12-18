using System;
using AnagramDetection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramDetectionTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = true;
            var actual = Kata.IsAnagram("foefet", "toffee");
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expect = true;
            var actual = Kata.IsAnagram("Buckethead", "DeathCubeK");
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expect = true;
            var actual = Kata.IsAnagram("Twoo", "Woot");
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var expect = false;
            var actual = Kata.IsAnagram("apple", "pale");
            Assert.AreEqual(expect, actual);
        }
    }
}
