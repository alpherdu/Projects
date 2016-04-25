using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MaximumSumIncreasingSubsequenceUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV.MaximumSumIncreasingSubsequence msis = new IV.MaximumSumIncreasingSubsequence();

            int[] A = { 1, 101, 2, 3, 100, 4, 5 };
            //int[] A = { 1, 101, 2, 3, 100};
            //int[] A = { 1, 101, 2, 3 };
            //int[] A = { 1, 101, 2 };
            //int[] A = { 1, 101 };
            //int[] A = { 1 };
            var maxSum = msis.GetMaximumSumIncreasingSubsequence_Recursive(A);

        }

        [TestMethod]
        public void DP_TestMethod1()
        {
            IV.MaximumSumIncreasingSubsequence msis = new IV.MaximumSumIncreasingSubsequence();

            int[] A = { 1, 101, 2, 3, 100, 4, 5 };
            //int[] A = { 1, 101, 2, 3, 100};
            //int[] A = { 1, 101, 2, 3 };
            //int[] A = { 1, 101, 2 };
            //int[] A = { 1, 101 };
            //int[] A = { 1 };
            var maxSum = msis.GetMaximumSumIncreasingSubsequence_DP(A);

        }
    }
}
