using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BT_UnitTest
{
    [TestClass]
    public class RatInMazeUnitTest
    {
        [TestMethod]
        public void RatInMazeTestMethod()
        {
            int[,] maze =
            {
                {1, 0, 0, 0},
                {1, 1, 0, 1},
                {0, 1, 0, 0},
                {1, 1, 1, 1}
            };

            BT.RatInMaze ratInMaze = new BT.RatInMaze(maze);
            if (ratInMaze.SolveIt(0, 0))
            {
                string solution = ratInMaze.PrintSolution();
            }

        }
    }
}
