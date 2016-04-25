using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set11_EggDroppingPuzzle
    {
        public int MinTrails_Recursive(int eggs, int floors)
        {
            if (floors == 0 || floors == 1) return floors;

            if (eggs == 1) return floors;

            int minTrials = int.MaxValue;
            for (int f = 1; f < floors + 1; f++)
            {
                int x = 1 + Math.Max(MinTrails_Recursive(eggs - 1, f - 1), MinTrails_Recursive(eggs, floors - f));
                if (x < minTrials) minTrials = x;
            }

            return minTrials;
        }
        public int MinTrails_DP(int eggs, int floors)
        {
            int[,] dp = new int[eggs + 1, floors + 1];

            //one ege
            for (int f = 1; f < floors + 1; f++) dp[1, f] = f;

            //one floor
            for (int egg = 1; egg < eggs + 1; egg++) dp[egg, 1] = 1;

            for (int egg = 2; egg < eggs + 1; egg++)
            {
                for (int f = 2; f < floors + 1; f++)
                {
                    int min = int.MaxValue;
                    for (int t = 1; t <= f; t++)//try each floor [1- f]
                    {
                        int x = 1 + Math.Max(dp[egg - 1, t - 1], dp[egg, f - t]);
                        if (min > x) min = x;
                    }

                    dp[egg, f] = min;
                }
            }
            
            return dp[eggs,floors];
        }
    }
}
