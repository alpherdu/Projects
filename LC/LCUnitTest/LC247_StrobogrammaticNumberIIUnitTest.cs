using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LCUnitTest
{
    [TestClass]
    public class LC247_StrobogrammaticNumberIIUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> y;
            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(1);
            Assert.AreEqual(3, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(2);
            Assert.AreEqual(4, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(3);
            Assert.AreEqual(4 * 3, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(4);
            Assert.AreEqual(4 * 5, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(5);
            Assert.AreEqual(4 * 5 * 3, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(6);
            Assert.AreEqual(4 * 5 * 5, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(7);
            Assert.AreEqual(4 * 5 * 5 * 3, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(8);
            Assert.AreEqual(4 * 5 * 5 * 5, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(9);
            Assert.AreEqual(4 * 5 * 5 * 5 * 3, y.Count);

            y = LC.LC247_StrobogrammaticNumberII.FindStrobogrammatic(10);
            Assert.AreEqual(4 * 5 * 5 * 5 * 5, y.Count);


        }
    }
}
