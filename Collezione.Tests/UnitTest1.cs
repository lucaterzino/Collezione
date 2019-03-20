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


       
    }
}
