using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public struct Pair
    {
        public int x;
        public int y;
    }
    public class Set20_MaximumLengthChainOfPairs
    {
        public int MaxLengthPairs(Pair[] pairs)
        {
            if (pairs == null || pairs.Length == 0) return 0;
            int N = pairs.Length;

            int[] dp = new int[N];

            for (int i = 0; i < N; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (pairs[j].y < pairs[i].x && dp[i] < dp[j] + 1)
                        dp[i] = dp[j] + 1;
                }

            }

            int max = int.MinValue;
            foreach (var item in dp)
                if (max < item) max = item;

            return max;
        }
    }
}
