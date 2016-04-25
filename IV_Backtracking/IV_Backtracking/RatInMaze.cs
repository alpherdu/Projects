using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class RatInMaze
    {
        int M, N;
        int[,] maze;

        public RatInMaze(int[,] maze)
        {
            this.maze = maze;
            this.M = maze.GetLength(0);
            this.N = maze.GetLength(1);
        }
        bool IsSafe(int x, int y, int[,] maze)
        {
            return x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1) && maze[x, y] == 1;
        }

        public bool SolveIt()
        {
            int[,] sol = new int[M, N];

            return SolveItUtil(sol, 0, 0, -1);
        }

        bool SolveItUtil(int[,] sol, int x, int y, int moveSN)
        {
            if (IsSafe(x, y, maze))
            {
                sol[x, y] = moveSN;

                if (x == M - 1 && y == N - 1) return true;

                if (SolveItUtil(sol, x + 1, y, moveSN - 1)) return true;
                if (SolveItUtil(sol, x, y + 1, moveSN - 1)) return true;

                sol[x, y] = 0;
            }
            return false;
        }
    }
}
