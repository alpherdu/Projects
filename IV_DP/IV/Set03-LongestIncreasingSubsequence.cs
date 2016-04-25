using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class LongestIncreasingSubsequence
    {
        public static int FindLIS_NLogN(int[] input, out string result)
        {
            int LISPtr = 0;
            int[] tailPos = Enumerable.Repeat<int>(-1, input.Length).ToArray<int>();
            int[] previous = Enumerable.Repeat<int>(-1, input.Length).ToArray<int>();
            //int[] previous2 = new int[input.Length];
            //previous.InitializeWithValue<int>(-1);

            //{ 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            tailPos[0] = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[tailPos[0]])
                {
                    tailPos[0] = i;
                }
                else if (input[i] > input[tailPos[LISPtr]])
                {
                    previous[i] = tailPos[LISPtr];
                    tailPos[++LISPtr] = i;
                }
                else
                {
                    int curTailPos = BSTailPos(tailPos.SubArray<int>(0, LISPtr + 1), input, input[i]);
                    previous[i] = previous[tailPos[curTailPos]];
                    tailPos[curTailPos] = i;
                }
            }

            int curIndex = tailPos[LISPtr];
            StringBuilder sb = new StringBuilder(LISPtr + 1);
            do
            {
                sb.Insert(0, input[curIndex] + ",");
                curIndex = previous[curIndex];
            } while (curIndex != -1);
             
            result = sb.ToString();
            return LISPtr + 1;
        }

        private static int BSTailPos(int[] tailPos, int[] input, int value)
        {
            int lo, hi, mid;
            lo = 0;
            hi = tailPos.Length - 1;

            while ( lo < hi)
            {
                mid = (lo + hi) / 2;

                if(value < input[tailPos[mid]])
                {
                    hi = mid-1;
                }
                else if(value >= input[tailPos[mid]])
                {
                    lo = mid+1;
                }
            }

            return lo; // lo==hi==mid; ?
        }

        public static T[] InitializeWithValue<T>(this T[] data, T initValue)
        {
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = initValue;
            }

            return data;
        }
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
        public static int FindLIS_DP(int[] array, out string result)
        {
            result = string.Empty;

            int[] LIS = new int[array.Length];
            int[] previous = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                LIS[i] = 1;
                previous[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[i])
                    {
                        if (LIS[i] < LIS[j] + 1)
                        {
                            LIS[i] = LIS[j] + 1;
                            previous[i] = j;
                        }
                    }
                }
            }

            int maxEndingIndex = 0;
            for (int i = 1; i < LIS.Length; i++)
            {
                if (LIS[maxEndingIndex] < LIS[i])
                {
                    maxEndingIndex = i;
                }
            }

            int curIndex = maxEndingIndex;
            while (curIndex != -1)
            {
                result = array[curIndex] + "," + result;
                curIndex = previous[curIndex];
            }

            return LIS[maxEndingIndex];
        }


        public static int FindLIS_Recursive(int[] array, out string result)
        {
            int maxLIS = 1;
            result = array[array.Length - 1].ToString();

            if (array.Length != 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[array.Length - 1])
                    {
                        int[] sub = array.SubArray<int>(0, i + 1);
                        string tempResult;
                        int tempLIS = FindLIS_Recursive(sub, out tempResult) + 1;
                        if (maxLIS < tempLIS)
                        {
                            maxLIS = tempLIS;
                            result = tempResult + "," + array[array.Length - 1].ToString();
                        }
                    }
                }
            }

            return maxLIS;
        }

        //wrong, when the second to the last was smaillesr, it will fail
        public static string FindLIS_NxN(int[] array)
        {
            //check inputArray;
            int[] LIS = new int[array.Length];
            string[] result = new string[array.Length];

            //ending at i;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                LIS[i] = 1;
                int temp = array[i];
                result[i] = array[i].ToString();

                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] < temp)
                    {
                        LIS[i]++;
                        temp = array[j];
                        result[i] = array[j].ToString() + "," + result[i];
                    }
                }
            }

            return string.Empty;
        }


    }

}
