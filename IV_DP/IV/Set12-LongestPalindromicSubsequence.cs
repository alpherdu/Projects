using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class LongestPalindromicSubsequence
    {
        public static string LPS_DP(string s)
        {
            if (s == null || s.Length == 0) return string.Empty;

            char[] array = s.ToArray();
            int arrayLen = array.Length;
            if (arrayLen == 1) return s;

            int[,] dp = new int[arrayLen + 1, arrayLen];

            for (int len = 1; len <= arrayLen; len++)
            {
                for (int endIndex = len - 1; endIndex < arrayLen; endIndex++)
                {
                    if (len == 1) dp[len, endIndex] = 1;
                    else
                    {
                        if (array[endIndex] == array[endIndex - len + 1])
                            dp[len, endIndex] = dp[len - 2, endIndex - 1] + 2;
                        else
                            dp[len, endIndex] = Math.Max(dp[len - 1, endIndex], dp[len - 1, endIndex - 1]);
                    }
                }
            }

            //build the palindrome
            StringBuilder sbLeft = new StringBuilder();
            StringBuilder sbRight = new StringBuilder();
            int i = arrayLen, j = arrayLen - 1;
            while (dp[i, j] > 0)
            {
                if (dp[i, j] == 1)
                {
                    sbLeft.Append(array[j]);
                    break;
                }
                else if (dp[i, j] == dp[i - 1, j]) i--;
                else if (dp[i, j] == dp[i - 1, j - 1])
                {
                    i--;
                    j--;
                }
                else if (dp[i, j] == dp[i - 2, j - 1] + 2)
                {
                    sbLeft.Append(array[j]);
                    sbRight.Insert(0, array[j]);
                    i -= 2;
                    j--;
                }

                //else j += 0; //no such case
            }
            //if(dp[i, j] == 1)sbLeft.Append(array[j]);
            sbLeft.Append(sbRight);

            return sbLeft.ToString();
        }


        public static int LPS_Recursive(char[] array)
        {
            if (array == null || array.Length == 0) return 0;

            return LPS_Recursive(array, 0, endIndex: array.Length - 1);
        }
        static int LPS_Recursive(char[] array, int startIndex, int endIndex)
        {
            if (endIndex < startIndex) return 0;
            if (endIndex == startIndex) return 1;

            if (array[startIndex] == array[endIndex]) return 2 + LPS_Recursive(array, startIndex + 1, endIndex - 1);
            else return Math.Max(LPS_Recursive(array, startIndex, endIndex - 1), LPS_Recursive(array, startIndex + 1, endIndex));
        }

    }
}
