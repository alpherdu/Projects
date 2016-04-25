using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set29_LongestCommonSubstring
    {
        public int GetLCSubStringLen(string X, string Y)
        {
            if (String.IsNullOrEmpty(X) || String.IsNullOrEmpty(Y)) return 0;

            int m = X.Length;
            int n = Y.Length;

            //pading row[0], and col[0]
            int[,] dp = new int[X.Length + 1, Y.Length + 1]; // defautlt value is 0;

            int max = int.MinValue;
            for (int i = 1; i < X.Length + 1; i++) 
            {
                for (int j = 1; j < Y.Length + 1; j++)
                {
                    if (X[i - 1] == Y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        if (dp[i, j] > max) max = dp[i, j];
                    }
                }
            }

            return max;
        }
    }
}
