using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class NQueen
    {
        int N;
        int[,] board;

        public NQueen(int N)
        {
            this.N = N;
            this.board = new int[N, N];
        }

        public bool SolveIt()
        {
            return SolveItUtil(0);
        }
        private bool SolveItUtil(int curColumn) //curColumn
        {
            if (curColumn >= N) return true;

            for (int row = 0; row < N; row++)
            {
                if (IsSafe(row, curColumn))
                {
                    this.board[row, curColumn] = curColumn + 1;
                    if (SolveItUtil(curColumn + 1)) return true;
                    this.board[row, curColumn] = 0;
                }
            }

            return false;
        }

        private bool IsSafe(int x, int y)
        {
            //same row on the left side
            for (int j = 0; j < y; j++) if (board[x, j] != 0) return false;

            //upper diagonal on the left side
            for (int i = x, j = y; i >= 0 && j >= 0; i--, j--) if (board[i, j] != 0) return false;

            //lower diagonal on the left side
            for (int i = x, j = y; i < N && j >= 0; i++, j--) if (board[i, j] != 0) return false;

            return true;
        }

    }
}
