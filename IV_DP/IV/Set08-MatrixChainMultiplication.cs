using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set08_MatrixChainMultiplication
    {
        // Matrix Ai has dimension p[i - 1] x p[i] for i = 1..n
        public int MatrixChainOrder_Recursive(int[] p, int i, int j)
        {
            if (i == j) return 0;

            int min = int.MaxValue;
            for (int k = i; k < j; k++)
            {
                var x = MatrixChainOrder_Recursive(p, i, k)
                    + p[i - 1] * p[k] * p[j]
                    + MatrixChainOrder_Recursive(p, k + 1, j);

                if (x < min) min = x;
            }

            return min;
        }

        public int MatrixChainOrder_DP(int[] p)
        {
            int M = p.Length - 1; // total of matrix

            int[,] dp = new int[M + 1, M + 1];

            for (int L = 2; L <= M; L++)
            {
                for (int firstMtrix = 0; firstMtrix <= M - L; firstMtrix++)
                {
                    int min = int.MaxValue;
                    for (int leftLen = 1; leftLen < L; leftLen++)
                    {
                        var temp = dp[leftLen, firstMtrix]
                            + p[firstMtrix] * p[firstMtrix + leftLen] * p[firstMtrix + L]
                            + dp[L - leftLen, firstMtrix + leftLen];

                        if (min > temp) min = temp;
                    }
                    dp[L, firstMtrix] = min;
                }
            }

            return dp[M, 0];
        }


    }
}
