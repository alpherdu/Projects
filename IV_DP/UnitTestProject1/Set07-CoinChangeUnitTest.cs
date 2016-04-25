using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CoinChangeUnitTest
    {
        #region DP_Space_O_n
        [TestMethod]
        public void CoinChange_DP_Space_O_n_TestMethod()
        {
            int value = 4;
            int[] coinSet = { 1, 2, 3 };

            int exptectedWays = 4;
            int result = IV.CoinChange.CoinChange_DP_Space_O_n(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }

        [TestMethod]
        public void CoinChange_DP_Space_O_n_TestMethod1()
        {
            int value = 10;
            int[] coinSet = { 1, 2, 3 };

            int exptectedWays = 14;
            int result = IV.CoinChange.CoinChange_DP_Space_O_n(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }

        [TestMethod]
        public void CoinChange_DP_Space_O_n_TestMethod2()
        {
            int value = 10;
            int[] coinSet = { 2, 5, 3, 6 };

            int exptectedWays = 5;
            int result = IV.CoinChange.CoinChange_DP_Space_O_n(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }
        #endregion

        #region DP
        [TestMethod]
        public void CoinChange_DP_TestMethod()
        {
            int value = 4;
            int[] coinSet = { 1, 2, 3 };

            int exptectedWays = 4;
            int result = IV.CoinChange.CoinChange_DP(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }

        [TestMethod]
        public void CoinChange_DP_TestMethod1()
        {
            int value = 10;
            int[] coinSet = { 1, 2, 3 };

            int exptectedWays = 14;
            int result = IV.CoinChange.CoinChange_DP(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }

        [TestMethod]
        public void CoinChange_DP_TestMethod2()
        {
            int value = 10;
            int[] coinSet = { 2, 5, 3, 6 };

            int exptectedWays = 5;
            int result = IV.CoinChange.CoinChange_DP(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }
        #endregion

        #region recursive
        [TestMethod]
        public void CoinChange_Recursive_TestMethod()
        {
            int value = 4;
            int[] coinSet = { 1, 2, 3 };

            int exptectedWays = 4;
            int result = IV.CoinChange.CoinChange_Recursive(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }

        [TestMethod]
        public void CoinChange_Recursive_TestMethod1()
        {
            int value = 10;
            int[] coinSet = { 1, 2, 3 };

            int exptectedWays = 14;
            int result = IV.CoinChange.CoinChange_Recursive(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }

        [TestMethod]
        public void CoinChange_Recursive_TestMethod2()
        {
            int value = 10;
            int[] coinSet = { 2, 5, 3, 6 };

            int exptectedWays = 5;
            int result = IV.CoinChange.CoinChange_Recursive(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }
        #endregion

        #region DP_Space_O_n_2
        [TestMethod]
        public void CoinChange_DP_Space_O_n_2_TestMethod()
        {
            int value = 20;
            int[] coinSet = { 2, 3, 5 };

            int exptectedWays = 11;
            int result = IV.CoinChange.CoinChange_DP_Space_O_n(coinSet, value);

            Assert.AreEqual(exptectedWays, result);
        }
        #endregion

    }
}
