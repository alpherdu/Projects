using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    /*
    Given an array of n positive integers. Write a program to find the sum of maximum sum subsequence 
    of the given array such that the intgers in the subsequence are sorted in increasing order. 
    For example, if input is {1, 101, 2, 3, 100, 4, 5}, then output should be 106 (1 + 2 + 3 + 100),
    if the input array is {3, 4, 5, 10}, then output should be 22 (3 + 4 + 5 + 10)
    and if the input array is {10, 5, 4, 3}, then output should be 10
    */
    public class MaximumSumIncreasingSubsequence
    {
        public int GetMaximumSumIncreasingSubsequence_Recursive(int[] A)
        {
            if(A == null || A.Length == 0) return 0;

            int gMaxSIS = int.MinValue;
            int gLastIndex = -1;
            int[] pre = new int[A.Length];

            MaximumSumIncreasingSubsequence_Recursive(A, A.Length - 1, pre, ref gMaxSIS, ref gLastIndex);

            string sequence = BuildSequence(A, pre, gLastIndex);

            return gMaxSIS;
        }

        private int MaximumSumIncreasingSubsequence_Recursive(int[] A, int lastIndex, int[] pre, ref int gMaxSIS, ref int gLastIndex)
        {
            int localMaxSIS = A[lastIndex];
            int localpre = -1;

            for (int i = 0; i < lastIndex; i++)
            {
                var segmentMaxSum = MaximumSumIncreasingSubsequence_Recursive(A, i, pre, ref gMaxSIS, ref gLastIndex);
                if (A[i] < A[lastIndex] && localMaxSIS < segmentMaxSum + A[lastIndex])
                {
                    localMaxSIS = segmentMaxSum + A[lastIndex];
                    localpre = i;
                }
            }

            pre[lastIndex] = localpre;

            if (localMaxSIS > gMaxSIS)
            {
                gMaxSIS = localMaxSIS;
                gLastIndex = lastIndex;
            }

            return localMaxSIS;
        }

        private string BuildSequence(int[] A, int[] pre, int gMaxEnding)
        {
            StringBuilder sb = new StringBuilder();

            do
            {
                sb.Insert(0, A[gMaxEnding] + ",");

                gMaxEnding = pre[gMaxEnding];
            } while (gMaxEnding != -1);

            return sb.ToString();
        }

        /////////////////////////////////////////////////////////////////////
        public int GetMaximumSumIncreasingSubsequence_DP(int[] A)
        {
            if (A == null || A.Length == 0) return 0;

            int gMaxSIS = int.MinValue;
            int[] maxSIS = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                int segmentMaxSum = A[i];
                for (int j = 0; j < i; j++)
                {
                    if (A[j] < A[i] && segmentMaxSum < maxSIS[j] + A[i])
                        segmentMaxSum = maxSIS[j] + A[i];
                }
                maxSIS[i] = segmentMaxSum;

                if (gMaxSIS < maxSIS[i]) gMaxSIS = maxSIS[i];
            }

            return gMaxSIS;
        }

    }
}
