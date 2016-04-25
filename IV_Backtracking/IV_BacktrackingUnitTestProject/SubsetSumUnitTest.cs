using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class SubsetSumUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] weights = { 30, 7, 5, 18, 12, 20, 15 };
            IV_Backtracking.SubsetSum subsetSum = new IV_Backtracking.SubsetSum(weights);
            var x = subsetSum.GenerateSubsets(53);
        }
    }
}
