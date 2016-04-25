using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MatrixChainMultiplicationUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = { 40, 20, 30, 10, 30 };

            IV.Set08_MatrixChainMultiplication mcm = new IV.Set08_MatrixChainMultiplication();
            var x = mcm.MatrixChainOrder_Recursive(A, 1, A.Length - 1);

            Assert.AreEqual(26000, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] A = { 1, 2, 3, 4, 3 };

            IV.Set08_MatrixChainMultiplication mcm = new IV.Set08_MatrixChainMultiplication();
            var x = mcm.MatrixChainOrder_Recursive(A, 1, A.Length - 1);

            Assert.AreEqual(30, x);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] A = { 40, 20, 30, 10, 30 };

            IV.Set08_MatrixChainMultiplication mcm = new IV.Set08_MatrixChainMultiplication();
            var x = mcm.MatrixChainOrder_DP(A);

            Assert.AreEqual(26000, x);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] A = { 1, 2, 3, 4, 3 };

            IV.Set08_MatrixChainMultiplication mcm = new IV.Set08_MatrixChainMultiplication();
            var x = mcm.MatrixChainOrder_DP(A);

            Assert.AreEqual(30, x);
        }
    }
}
