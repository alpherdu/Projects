using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class KnightTourUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV_Backtracking.KnightTour kt = new IV_Backtracking.KnightTour(8, 8);
            var x = kt.SolveKT();

            var sol = kt.PrintOutSolution();
        }
    }
}
