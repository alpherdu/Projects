using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class EditDistanceUnitTest
    {
        [TestMethod]
        public void EditDistance_DP_TestMethod1()
        {
            string X = "kitten";
            string y = "sitting";
            string editOps;

            int expectedED = 3;
            int resultED = IV.EditDistance.EditDistance_DP(X, y, out editOps);

            Assert.AreEqual(expectedED, resultED);
        }

        [TestMethod]
        public void EditDistance_Recursive_TestMethod1()
        {
            string X = "kitten";
            string y = "sitting";
            string editOps;

            int expectedED = 3;
            int resultED = IV.EditDistance.EditDistance_Recursive(X, y, out editOps);

            Assert.AreEqual(expectedED, resultED);
        }
    }
}
