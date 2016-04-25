using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MinCostPathUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] cost = new int[,]
                {
                    { 1, 2, 3 },
                    { 4, 8, 2 },
                    { 1, 5, 3 }
                };

            int expetedResult = 8;
            int result = IV.MinCostPath.MinCostPath_DP(cost, 3, 3);

            Assert.AreEqual(expetedResult, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[,] cost = new int[,]
                {
                    { 1, 3, 3, 5},
                    { 3, 8, 2, 8},
                    { 6, 1, 2, 4},
                    { 6, 5, 3, 2}
                };

            int expetedResult = 9;
            int result = IV.MinCostPath.MinCostPath_DP(cost, 4, 4);

            Assert.AreEqual(expetedResult, result);
        }
    }
}
