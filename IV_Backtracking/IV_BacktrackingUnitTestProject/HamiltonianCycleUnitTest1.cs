using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class HamiltonianCycleUnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // (0)--(1)--(2)
            // |   / \   |
            // |  /   \  |
            // | /     \ |
            // (3)-------(4)
            int[,] graph = {
                {0, 1, 0, 1, 0},
                {1, 0, 1, 1, 1},
                {0, 1, 0, 0, 1},
                {1, 1, 0, 0, 1},
                {0, 1, 1, 1, 0}
            };

            IV_Backtracking.HamiltonianCycle hCycle = new IV_Backtracking.HamiltonianCycle(graph);
            var x = hCycle.SolveIt( );
        }

        [TestMethod]
        public void TestMethod2()
        {
            // (0)--(1)--(2)
            // |   / \   |
            // |  /   \  |
            // | /     \ |
            // (3)       (4)
            int[,] graph = {
                {0, 1, 0, 1, 0},
                {1, 0, 1, 1, 1},
                {0, 1, 0, 0, 1},
                {1, 1, 0, 0, 0},
                {0, 1, 1, 0, 0}
            };


            IV_Backtracking.HamiltonianCycle hCycle = new IV_Backtracking.HamiltonianCycle(graph);
            var x = hCycle.SolveIt();
        }
    }
}
