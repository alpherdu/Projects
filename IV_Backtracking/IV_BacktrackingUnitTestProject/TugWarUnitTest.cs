using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class TugWarUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { 23, 45, -34, 12, 0, 98, -99, 4, 189, -1, 4 };

            IV_Backtracking.TugWar tugWar = new IV_Backtracking.TugWar();
            var x = tugWar.SolveIt(nums);

            Assert.AreEqual(1, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = { 3, 4, 5, -3, 100, 1, 89, 54, 23, 20 };

            IV_Backtracking.TugWar tugWar = new IV_Backtracking.TugWar();
            var x = tugWar.SolveIt(nums);

            Assert.AreEqual(0, x);
        }
    }
}
