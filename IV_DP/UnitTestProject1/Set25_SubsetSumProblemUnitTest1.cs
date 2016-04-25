using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set25_SubsetSumProblemUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 3, 34, 4, 12, 5, 2 };
            int sum = 9;

            IV.Set25_SubsetSumProblem ssp = new IV.Set25_SubsetSumProblem();
            var x = ssp.IsSubsetSum_Recursive(arr, arr.Length, sum);
        }
    }
}
