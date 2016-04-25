using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BinomialCoefficientUnitTest
    {
        int CalBC(int n, int k)
        {
            int result = 1;

            for (int i = 1; i <= k; i++)
            {
                result *= (n - i + 1);
                result /= i;
            }

            return result;
        }

        [TestMethod]
        public void BinomialCoefficient_Recursive_TestMethod()
        {
            int n = 5, k = 2;
            int expected = CalBC(n, k);
            int resutl = IV.BinomialCoefficient.BinomialCoefficient_Recursive(n, k);

            Assert.AreEqual(expected, resutl);
        }

        [TestMethod]
        public void BinomialCoefficient_Dp_TestMethod()
        {
            int n = 10, k = 2;
            int expected = CalBC(n, k);
            int resutl = IV.BinomialCoefficient.BinomialCoefficient_DP(n, k);

            Assert.AreEqual(expected, resutl);
        }

        [TestMethod]
        public void BinomialCoefficient_TopDown_TestMethod()
        {
            int n = 10, k = 2;
            int expected = CalBC(n, k);
            int resutl = IV.BinomialCoefficient.BinomialCoefficient_Topdown(n, k);

            Assert.AreEqual(expected, resutl);
        }
    }
}
