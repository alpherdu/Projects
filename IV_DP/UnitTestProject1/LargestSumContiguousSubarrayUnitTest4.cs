using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LargestSumContiguousSubarrayUnitTest4
    {
        [TestMethod]
        public void LargestSumContiguousSubarray_DP_TestMethod1()
        {
            int[] input = { -2, -3, 4, -1, -2, 1, 5, -3 };
            string expectResult = "4,-1,-2,1,5";
            int expectedMaxSum = 7;

            string result;
            int maxSum = IV.LargestSumContiguousSubarray.LargestSumContiguousSubarray_DP(input, out result);

            Assert.AreEqual(expectedMaxSum, maxSum);
            Assert.AreEqual(expectResult, result);
        }


        [TestMethod]
        public void LargestSumContiguousSubarray_DP_AllNegative_TestMethod1()
        {
            int[] input = { -2, -3, -4, -1, -2, -1, -5, -3};

            string expectResult = "-1";
            int expectedMaxSum = -1;

            string result;
            int maxSum = IV.LargestSumContiguousSubarray.LargestSumContiguousSubarray_DP(input, out result);

            Assert.AreEqual(expectedMaxSum, maxSum);
            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void LargestSumContiguousSubarray_BrouteForce_TestMethod1()
        {
            int[] input = { -2, -3, 4, -1, -2, 1, 5, -3 };
            string expectResult = "4,-1,-2,1,5";
            int expectedMaxSum = 7;

            string result;
            int maxSum = IV.LargestSumContiguousSubarray.LargestSumContiguousSubarray_BruteForce(input, out result);

            Assert.AreEqual(expectedMaxSum, maxSum);
            Assert.AreEqual(expectResult, result);
        }
    }
}

