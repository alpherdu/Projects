using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LISUnitTest
    {
        [TestMethod]
        public void LIS_NLogNTestMethod()
        {
            int[] inputArray = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            string expectedResult = "0,4,6,9,11,15,";
            //string expectedResult = "0,4,6,9,13,15,";
            //string expectedResult = "0,2,6,9,11,15";

            string result;
            int LIS = IV.LongestIncreasingSubsequence.FindLIS_NLogN(inputArray, out result);

            Assert.AreEqual(6, LIS);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void LIS_NxNTestMethod()
        {
            int[] inputArray = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };

            string result = IV.LongestIncreasingSubsequence.FindLIS_NxN(inputArray);

            //int LIS = IV.LongestIncreasingSubsequence.FindLIS_Recursive(inputArray, out result);
        }

        [TestMethod]
        public void LIS_DPTestMethod()
        {
            int[] inputArray = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            //string expectedResult = "0,4,6,9,11,15,";
            string expectedResult = "0,4,6,9,13,15,";
            //strinexpectedResult = "0,2,6,9,11,15";

            string result;
            int LIS = IV.LongestIncreasingSubsequence.FindLIS_DP(inputArray, out result);

            Assert.AreEqual(6, LIS);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void LIS_RecursiveTestMethod()
        {
            int[] inputArray = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            //string expectedResult = "0,4,6,9,11,15";
            string expectedResult = "0,4,6,9,13,15";
            //strinexpectedResult = "0,2,6,9,11,15";

            string result;
            int LIS = IV.LongestIncreasingSubsequence.FindLIS_Recursive(inputArray, out result);

            Assert.AreEqual(6, LIS);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
