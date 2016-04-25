using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class Knapsack_0_1
    {
        public struct Result
        {
            public int maxWeight;
            public int maxValue;
            public List<int> weights;
            public Result(int x)
            {
                this.maxValue = 0;
                this.maxWeight = 0;
                this.weights = new List<int>();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < weights.Count; i++)
                {

                }
                return "{" + maxWeight + "(" + string.Join("+", weights.ToArray()) + ")," + maxValue + "}";
            }
        }

        public static Result Knapsack_Recursive(int capacity, int[] weights, int[] values, int itemsCount)
        {
            Result result = new Result(0);
            if (capacity == 0 || itemsCount == 0) return result;

            if (weights[itemsCount - 1] > capacity)
                return Knapsack_Recursive(capacity, weights, values, itemsCount - 1);

            Result rWithoutLastWeight, rWithLastWeight;
            rWithoutLastWeight = Knapsack_Recursive(capacity, weights, values, itemsCount - 1);
            rWithLastWeight = Knapsack_Recursive(capacity - weights[itemsCount - 1], weights, values, itemsCount - 1);
            rWithLastWeight.maxValue += values[itemsCount - 1];
            rWithLastWeight.weights.Add(weights[itemsCount - 1]);

            return rWithoutLastWeight.maxValue > rWithLastWeight.maxValue ? rWithoutLastWeight : rWithLastWeight;
        }

        public static Result Knapsack_DP(int capacity, int[] weights, int[] values, int itemsCount)
        {
            Result[,] dp = new Result[itemsCount + 1, capacity + 1];

            for (int w = 0; w < itemsCount + 1; w++)
            {
                for (int c = 0; c < capacity + 1; c++) //capacity
                {
                    dp[w, c] = new Result(0);

                    if ( w != 0)
                    {
                        Result rWithoutLastWeight = new Result(0);
                        rWithoutLastWeight.maxValue = dp[w - 1, c].maxValue;
                        rWithoutLastWeight.maxWeight = dp[w - 1, c].maxWeight;
                        rWithoutLastWeight.weights.AddRange(dp[w - 1, c].weights);

                        if (weights[w-1] > c)
                        {
                            dp[w, c] = rWithoutLastWeight;
                        }
                        else
                        {
                            Result rWithLastWeight = new Result(0);
                            if (c - weights[w - 1] >= 0)
                            {
                                rWithLastWeight.maxValue = values[w - 1] + dp[w - 1, c - weights[w - 1]].maxValue;
                                rWithLastWeight.maxWeight = weights[w - 1] + dp[w - 1, c - weights[w - 1]].maxWeight;

                                rWithLastWeight.weights.AddRange(dp[w - 1, c - weights[w - 1]].weights);
                                rWithLastWeight.weights.Add(weights[w - 1]);

                                dp[w, c] = rWithoutLastWeight.maxValue > rWithLastWeight.maxValue ? rWithoutLastWeight : rWithLastWeight;
                            }
                        }
                    }
                }
            }

            return dp[itemsCount, capacity];
        }
    }
}
