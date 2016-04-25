using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class KnightTour
    {
        int M, N;
        int[,] sol;

        public KnightTour(int M, int N)
        {
            this.M = M;
            this.N = N;
        }

        public bool SolveKT()
        {
            int[,] nextMove = new int[,]{
                { 2, 1, -1, -2, -2, -1,  1,  2 },
                { 1, 2,  2,  1, -1, -2, -2, -1} };

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    this.sol = new int[M, N];
                    sol[i, j] = 1;
                    if( SolveKTUtil(sol, i, j, 2, nextMove)) return true;
                }
            }
            return false;
        }

        bool SolveKTUtil(int[,] sol, int x, int y, int nextMoveSN, int[,] nextMove)
        {
            if (nextMoveSN == M * N + 1) return true;

            for (int k = 0; k < 8; k++)
            {
                int nextX = x + nextMove[0, k];
                int nextY = y + nextMove[1, k];
                if (IsSafe(nextX, nextY, sol))
                {
                    sol[nextX, nextY] = nextMoveSN;
                    if (SolveKTUtil(sol, nextX, nextY, nextMoveSN + 1, nextMove)) //return when the first sol is found
                        return true;
                    else
                        sol[nextX, nextY] = 0;
                }
            }
            return false;
        }

        bool IsSafe(int x, int y, int[,] sol)
        {
            return x >= 0 && x < M && y >= 0 && y < N && sol[x, y] == 0;
        }
        public string PrintOutSolution()
        {
            StringBuilder sb = new StringBuilder();
            for (int x = 0; x < M; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    sb.Append(sol[x, y] + " ");
                }
                sb.Append(System.Environment.NewLine);
            }

            return sb.ToString();
        }
    }

}
