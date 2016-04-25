using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LongestBitonicSubsequenceUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };

            IV.Set15_LongestBitonicSubsequence lbs = new IV.Set15_LongestBitonicSubsequence();
            var x = lbs.GetLBS(A);
        }
    }
}
