using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set18_PartitionProblem
    {
        public bool Partition(int[] arr, StringBuilder sb)
        {
            int sum = 0;
            foreach (var item in arr) sum += item;

            if (sum % 2 != 0)
                return false;
            else
                return Partition_Recursive(arr, arr.Length, sum / 2, sb);
        }

        private bool Partition_Recursive(int[] arr, int n, int sum, StringBuilder sb)
        {
            if (sum == 0) return true;
            if (n == 0) return sum == 0;

            /*            //bug: If last element is greater than sum, then ignore it
                        if (arr[n - 1] > sum)
                            return Partition_Recursive(arr, n - 1, sum, sb);
            */
            if (Partition_Recursive(arr, n - 1, sum, sb)) return true;
            else if (Partition_Recursive(arr, n - 1, sum - arr[n - 1], sb))
            {
                sb.Insert(0, arr[n - 1] + ",");
                return true;
            }

            return false;
        }


        public bool Partition_dp(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr) sum += item;

            if (sum % 2 != 0)
                return false;
            else
                return Partition_dp(arr, sum / 2);
        }

        private bool Partition_dp(int[] arr, int sum)
        {
            if (sum == 0) return true;

            int N = arr.Length;
            if (N == 0) return sum == 0;

            bool[,] dp = new bool[sum + 1, N + 1];

            for (int i = 0; i < N + 1; i++) dp[0, i] = true;

            for (int s = 1; s < sum + 1; s++)
            {
                for (int j = 1; j < N + 1; j++) // 1- based.
                {
                    dp[s, j] = dp[s, j - 1];

                    if (s >= arr[j - 1])
                        dp[s, j] = dp[s, j] || dp[s - arr[j - 1], j - 1];
                }
            }

            return dp[sum, N];
        }


        public bool HalfSumSubset(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr) sum += item;

            bool[] dp = new bool[sum + 1];

            dp[0] = true; //base case;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = sum - arr[i]; j >= 0; j--)
                {
                    if (dp[j]) dp[j + arr[i]] = true;
                }
            }


            return dp[sum / 2];
        }
    }
}
