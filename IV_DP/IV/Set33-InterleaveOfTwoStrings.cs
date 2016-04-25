using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set33_InterleaveOfTwoStrings
    {
        public bool IsInterLeaved(string s1, string s2, string s3)
        {
            if (String.IsNullOrEmpty(s1)) return s2 == s3;
            if (String.IsNullOrEmpty(s2)) return s1 == s3;

            int M = s1.Length, N = s2.Length;
            if (M + N != s3.Length) return false;

            bool[,] dp = new bool[M + 1, N + 1]; //length
            dp[0, 0] = true;

            //Length of B is 0
            for (int i = 1; i < M + 1; i++)
            {
                if (s1[i - 1] == s3[i - 1] && dp[i - 1, 0]) dp[i, 0] = true;
            }

            //length of A is 0
            for (int j = 1; j < N + 1; j++)
            {
                if (s2[j - 1] == s3[j - 1] && dp[0, j - 1]) dp[0, j] = true;
            }

            for (int i = 1; i < M + 1; i++)
            {
                for (int j = 1; j < N + 1; j++)
                {
                    // when i is M and j is N, index of C should be M+N-1
                    if (s1[i - 1] == s3[i + j - 1] && s2[j - 1] != s3[i + j - 1])
                        dp[i, j] = dp[i - 1, j];
                    else if (s1[i - 1] != s3[i + j - 1] && s2[j - 1] == s3[i + j - 1])
                        dp[i, j] = dp[i, j - 1];
                    else if (s1[i - 1] == s3[i + j - 1] && s2[j - 1] == s3[i + j - 1])
                        dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                }
            }

            return dp[M, N];
        }
    }
}
