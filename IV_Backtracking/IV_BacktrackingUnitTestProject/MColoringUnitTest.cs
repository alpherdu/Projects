using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class MColoringUnitTest
    {
        [TestMethod]
        public void MColoringTestMethod()
        {
            int maxColors = 5;
            int[,] graph = {
                {0, 1, 1, 1},
                {1, 0, 1, 0},
                {1, 1, 0, 1},
                {1, 0, 1, 0}
            };

            IV_Backtracking.MColoring mColoring = new IV_Backtracking.MColoring(graph, maxColors);

            var hasSol = mColoring.SolvIt();
        }
    }
}
