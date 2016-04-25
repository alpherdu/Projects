using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set17_PalindromePartitioning
    {
        public int MinCost_Recursive(string str)
        {
            if (str == null || str.Length <= 1 || IsPalindrome(str)) return 0;

            int min = int.MaxValue;
            for (int leftLen = 1; leftLen < str.Length; leftLen++)
            {
                var x = 1 + MinCost_Recursive(str.Substring(0, leftLen)) + MinCost_Recursive(str.Substring(leftLen));

                if (min > x) min = x;
            }

            return min;
        }

        public int MinCost_DP(string str)
        {
            if (str == null || str.Length <= 1) return 0;

            int N = str.Length;

            int[,] dp = new int[N + 1, N + 1];

            for (int L = 2; L <= N; L++)
            {
                for (int start = 0; start <= N - L; start++)
                {
                    if (IsPalindrome(str.Substring(start, L)))
                        dp[L, start] = 0;
                    else
                    {
                        dp[L, start] = int.MaxValue;
                        for (int k = 1; k < L; k++) //cut: k is the len of left part
                        {
                            var x = 1 + dp[k, start] + dp[L - k, start + k];
                            if (dp[L, start] > x) dp[L, start] = x;
                        }
                    }
                }
            }

            return dp[N, 0];
        }

        bool IsPalindrome(string str)
        {
            int lo = 0, hi = str.Length - 1;

            for (; lo < hi && str[lo] == str[hi]; lo++, hi--) ;

            return lo >= hi;

        }

    }
}
