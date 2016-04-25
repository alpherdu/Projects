using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set36_MaximumProductCutting
    {
        /*Given a rope of length n meters, cut the rope in different parts of integer lengths
        in a way that maximizes product of lengths of all parts.You must make at least one cut. 
        Assume that the length of rope is more than 2 meters
        */

        public int MaxProductCut_Recursive(int L)
        {
            return MaxProductCut_Recursive(L, true);
        }
        private int MaxProductCut_Recursive(int L, bool hasToCut)
        {
            if (L <= 2) return L;

            int max = int.MinValue;
            for (int firstP = 1; firstP <= L - 1; firstP++)
            {
                var x = firstP * MaxProductCut_Recursive(L - firstP, hasToCut: false);
                if (max < x) max = x;
            }

            return hasToCut ? max : Math.Max(max, L);
        }

        public int MaxProductCut_Dp(int L)
        {
            if (L <= 2) return L;

            int[] dp = new int[L + 1];
            dp[1] = 1;
            dp[2] = 2;

            for (int len = 3; len <= L; len++)
            {
                int max = int.MinValue;
                for (int firstP = 1; firstP <= len - 1; firstP++)
                {
                    var x = firstP * Math.Max(len - firstP, dp[len - firstP]);
                    if (max < x) max = x;
                }
                dp[len] = max;
            }
            return dp[L];
        }
    }
}
