using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set17_PalindromePartitioningUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "ababbbabbababa";

            IV.Set17_PalindromePartitioning pp = new IV.Set17_PalindromePartitioning();
            var x = pp.MinCost_Recursive(str);
            Assert.AreEqual(3, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string str = "abcdbebfaga";

            IV.Set17_PalindromePartitioning pp = new IV.Set17_PalindromePartitioning();
            var x = pp.MinCost_Recursive(str);
            Assert.AreEqual(6, x);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string str = "ababbbabbababa";

            IV.Set17_PalindromePartitioning pp = new IV.Set17_PalindromePartitioning();
            var x = pp.MinCost_DP(str);
            Assert.AreEqual(3, x);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string str = "abcdbebfaga";

            IV.Set17_PalindromePartitioning pp = new IV.Set17_PalindromePartitioning();
            var x = pp.MinCost_DP(str);
            Assert.AreEqual(6, x);
        }
    }
}
