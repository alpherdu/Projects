using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class RatInMazeUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] maze =  {
                {1, 0, 0, 0},
                {1, 1, 0, 1},
                {0, 1, 0, 0},
                {1, 1, 1, 1}};

            IV_Backtracking.RatInMaze rim = new IV_Backtracking.RatInMaze(maze);

            var x = rim.SolveIt();


        }
    }
}
