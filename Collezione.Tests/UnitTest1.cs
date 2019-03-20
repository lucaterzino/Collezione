using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collezione.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVariabili()
        {
            int a = 2, b = a;
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void TestArray1()
        {
            int[] c = { 1, 2, 3, 4 };
            int[] d = c;
            Assert.AreEqual(c, d);
        }

        //Non sono uguali poichè i due array hanno due indirizzi diversi
        [TestMethod]
        public void TestArray2()
        {
            int[] e = { 1, 2, 3, 4 };
            int[] f = { 1, 2, 3, 4 };
            Assert.AreEqual(e, f);
        }


    }
}
