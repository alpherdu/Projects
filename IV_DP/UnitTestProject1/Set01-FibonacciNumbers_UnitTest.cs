using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FibNumberUnitTest
    {
        [TestMethod]
        public void FibonacciNumber_Recursive_TestMethod()
        {
            int n = IV.FibonacciNumbers.MAX_NUM;
            int expectedResult = 832040;

            int result = IV.FibonacciNumbers.FibonacciNumber_Recursive(n);

            Assert.AreEqual(expectedResult, result);

        }


        [TestMethod]
        public void Fib_Memoization_Memorization_TopDown_TestMethod()
        {
            int n = IV.FibonacciNumbers.MAX_NUM;
            int expectedResult = 832040;

            int result = IV.FibonacciNumbers.FibonacciNumbers_DP_Memorization_TopDown(n);

            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void Fib_Tablization_Tabulation_BottomUp_TestMethod()
        {
            int n = IV.FibonacciNumbers.MAX_NUM;
            int expectedResult = 832040;

            int result = IV.FibonacciNumbers.FibonacciNumbers_DP_Tabulation_BottomUp(n);

            Assert.AreEqual(expectedResult, result);

        }
    }
}
