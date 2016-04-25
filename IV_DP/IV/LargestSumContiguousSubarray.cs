using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class LargestSumContiguousSubarray
    {
        //N*N*N
        public static int LargestSumContiguousSubarray_BruteForce(int[] input, out string subArray)
        {
            int gMaxSum = int.MinValue;
            int gStartIndex = -1;
            int gEndIndex = -1;

            int curMaxSum;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    curMaxSum = 0;
                    for (int k = i; k <= j; k++)
                    {
                        curMaxSum += input[k];
                    }

                    if (curMaxSum > gMaxSum)
                    {
                        gMaxSum = curMaxSum;
                        gStartIndex = i;
                        gEndIndex = j;

                    }
                }
            }

            int sequenceLen = gEndIndex - gStartIndex + 1;
            int[] resultArray = new int[sequenceLen];
            Array.Copy(input, gStartIndex, resultArray, 0, sequenceLen);

            subArray = string.Join(",", resultArray);

            return gMaxSum;
        }

        //{-2, -3, 4, -1, -2, 1, 5, -3}
        //keep tracking previous max sum
        //for a subArray with a fixed ending, if preSum > o, combine them. otherwise, it self. 
        public static int LargestSumContiguousSubarray_DP(int[] input, out string subArray)
        {
            int gMaxSum = int.MinValue;
            int gStartIndex = -1;
            int gEndIndex = -1;

            int preMaxSum = int.MinValue;
            int preStartIndex = -1;
            int preEndIndex = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (preMaxSum > 0)
                {
                    preMaxSum += input[i];
                    preEndIndex = i;
                }
                else
                {
                    preMaxSum = input[i];
                    preStartIndex = i;
                    preEndIndex = i;
                }

                if(gMaxSum < preMaxSum)
                {
                    gMaxSum = preMaxSum;
                    gStartIndex = preStartIndex;
                    gEndIndex = preEndIndex;
                }
            }

            int sequenceLen = gEndIndex - gStartIndex + 1;
            int[] resultArray = new int[sequenceLen];
            Array.Copy(input, gStartIndex, resultArray, 0, sequenceLen);

            subArray = string.Join(",", resultArray);

            return gMaxSum;
        }
    }
}
