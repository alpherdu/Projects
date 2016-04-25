using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Knapsack_0_1_UnitTest
    {
        [TestMethod]
        public void Knapsack_RecursiveTestMethod()
        {
            int expectMaxValue = 220;

            int capacity = 50;
            int[] weights = { 10, 20, 30 };
            int[] values = { 60, 100, 120 };

            IV.Knapsack_0_1.Result r = IV.Knapsack_0_1.Knapsack_Recursive(capacity, weights, values, weights.Length);
            Assert.AreEqual(expectMaxValue, r.maxValue);
        }

        [TestMethod]
        //http://www.es.ele.tue.nl/education/5MC10/Solutions/knapsack.pdf
        public void Knapsack_RecursiveTestMethod2()
        {
            int expectMaxValue = 90;
            int capacity = 10;
            int[] weights = { 5, 4, 6, 3 };
            int[] values = { 10, 40, 30, 50 };

            IV.Knapsack_0_1.Result r = IV.Knapsack_0_1.Knapsack_Recursive(capacity, weights, values, weights.Length);
            Assert.AreEqual(expectMaxValue, r.maxValue);

        }

        [TestMethod]
        //http://www.es.ele.tue.nl/education/5MC10/Solutions/knapsack.pdf
        public void Knapsack_DPMethod2()
        {
            int expectMaxValue = 90;
            int capacity = 10;
            int[] weights = { 5, 4, 6, 3 };
            int[] values = { 10, 40, 30, 50 };

            IV.Knapsack_0_1.Result r = IV.Knapsack_0_1.Knapsack_DP(capacity, weights, values, weights.Length);
            Assert.AreEqual(expectMaxValue, r.maxValue);

        }
    }
}
