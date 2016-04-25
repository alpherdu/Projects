using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set29_LongestCommonSubstringUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string X = "OldSite:GeeksforGeeks.org";
            string Y = "NewSite:GeeksQuiz.com";

            IV.Set29_LongestCommonSubstring lcss = new IV.Set29_LongestCommonSubstring();
            var x  = lcss.GetLCSubStringLen(X, Y);
            Assert.AreEqual(10, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string X = "1235corg";
            string Y = "NewSite:GeeksQuiz.com";

            IV.Set29_LongestCommonSubstring lcss = new IV.Set29_LongestCommonSubstring();
            var x = lcss.GetLCSubStringLen(X, Y);
            Assert.AreEqual(2, x);
        }
    }
}
