using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class Sudoku
    {
        private int[,] board;
        public Sudoku(int[,] board)
        {
            this.board = board;
        }

        public bool SolveIt()
        {
            return SolveItUtil(0, 0);
        }

        public bool SolveItUtil(int curX, int curY)
        {
            int x = curX, y = curY;
            if (!FindNextEmptyCell(ref x, ref y)) return true;

            for (int i = 1; i <= 9; i++)
            {
                if (IsSafe(x, y, i))
                {
                    board[x, y] = i;
                    if (SolveItUtil(x, y)) return true;
                    board[x, y] = 0;
                }
            }

            return false;
        }

        private bool FindNextEmptyCell(ref int x, ref int y)
        {
            //optimization: no need to search any rows above curX
            for (; x < board.GetLength(0); x++)
            {
                for (y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] == 0) return true;
                }
            }

            return false;
        }

        private bool IsSafe(int x, int y, int number)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, y] == number) return false;
            }

            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[x, i] == number) return false;
            }

            int xOffset = x / 3 * 3;
            int yOffset = y / 3 * 3;
            for (int i = xOffset; i < xOffset + 3; i++)
            {
                for (int j = yOffset; j < yOffset + 3; j++)
                {
                    if (board[i, j] == number) return false;
                }
            }

            return true;
        }

    }
}
