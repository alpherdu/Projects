using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LCSUnitTest
    {
        [TestMethod]
        public void LCS_Recursive_TestMethod()
        {
            string x = "XMJYAUZ";
            string y = "MZJAWXU";

            int expectedLen = 4;
            int len = IV.LCS.LCS_Recursive(x, y);

            Assert.AreEqual(expectedLen, len);
        }

        [TestMethod]
        public void LCS_DP_TestMethod()
        {
            string x = "XMJYAUZ";
            string y = "MZJAWXU";

            int expectedLen = 4;
            string exptectLCSResult = "MJAU";
            string LCSResult;

            int len = IV.LCS.LCS_DP(x, y, out LCSResult);

            Assert.AreEqual(expectedLen, len);
            Assert.AreEqual(exptectLCSResult, LCSResult);
        }

    }
}
