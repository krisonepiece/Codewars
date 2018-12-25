using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseWords;

namespace ReverseWordsTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expect = "sihT si na !elpmaxe";
            var actual = Kata.ReverseWords("This is an example!");
            Assert.AreEqual(expect, actual);
        }
    }
}
