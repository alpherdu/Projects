using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class SudokuUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] board = {
                {3, 0, 6, 5, 0, 8, 4, 0, 0},
                {5, 2, 0, 0, 0, 0, 0, 0, 0},
                {0, 8, 7, 0, 0, 0, 0, 3, 1},
                {0, 0, 3, 0, 1, 0, 0, 8, 0},
                {9, 0, 0, 8, 6, 3, 0, 0, 5},
                {0, 5, 0, 0, 9, 0, 6, 0, 0},
                {1, 3, 0, 0, 0, 0, 2, 5, 0},
                {0, 0, 0, 0, 0, 0, 0, 7, 4},
                {0, 0, 5, 2, 0, 6, 3, 0, 0}
            };

            IV_Backtracking.Sudoku sudoku = new IV_Backtracking.Sudoku(board);
            var x = sudoku.SolveIt();
        }
    }
}
