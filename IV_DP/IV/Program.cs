using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace IV
{
    static public class IVClass
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            string s = "abc";
            foreach (var item in s)
            {
                item.aer();
            }

        }


        static string ReverseWords(string s)
        {
            if (s == null) return s;
            s = s.Trim();
            if (s.Length == 0) return s;

            char[] array = s.ToArray();
            StringBuilder sb = new StringBuilder();

            int start = 0, end = 0;
            for (int i = 0; i < array.Length; i++)
            {
                while (i < array.Length && array[i] == ' ') i++;

                start = i;
                while (i < array.Length && array[i] != ' ') i++;
                end = i - 1; //bug: end =i;

                sb.Insert(0, ' ');
                sb.Insert(0, array, start, end - start + 1);
            }

            return sb.ToString(0, sb.Length - 1);
        }


        public static int CalculateMinimumHP(int[,] dungeon)
        {
            if (dungeon == null || dungeon.Length == 0) return 1;

            int minHpToStart = 0;

            int m = dungeon.GetLength(0);
            int n = dungeon.GetLength(1);

            int[,] minExtraHpToMove = new int[m + 1, n + 1];
            for (int i = 0; i < m + 1; i++) minExtraHpToMove[i, n] = int.MaxValue;
            for (int j = 0; j < n + 1; j++) minExtraHpToMove[m, j] = int.MaxValue;
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    minExtraHpToMove[i, j] = dungeon[i, j];

                    if (i == m - 1 && j == n - 1)
                    {
                        minExtraHpToMove[i, j] = minExtraHpToMove[i, j] >= 0 ? 0 : -minExtraHpToMove[i, j];
                    }
                    else
                    {
                        minExtraHpToMove[i, j] -= Math.Min(minExtraHpToMove[i + 1, j], minExtraHpToMove[i, j + 1]);
                        if (i != 0 && i != 0)
                            minExtraHpToMove[i, j] = minExtraHpToMove[i, j] >= 0 ? 0 : -minExtraHpToMove[i, j];
                    }
                }
            }

            minHpToStart = minExtraHpToMove[0, 0] >= 1 ? 1 : 1 - minExtraHpToMove[0, 0];

            return minHpToStart;
        }

        //int x = ClimbStairs(4);
        public static int ClimbStairs(int n)
        {
            if (n < 0) return 0;
            if (n == 0) return 1;

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }

        //int[] array = { 1, 2 };
        //Rotate(array, 2);

        public static void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length <= 1) return;

            if (k >= nums.Length) k = k % nums.Length;

            //method 3: in-place with O(1) extra space
            int elementToMove = nums.Length;

            while (k > 0 && elementToMove != 0)
            {
                int lastElement = nums[elementToMove - 1];
                for (int moveUpIndex = elementToMove - 1 - k; moveUpIndex >= 0; moveUpIndex--)
                {
                    nums[moveUpIndex + k] = nums[moveUpIndex];
                    nums[moveUpIndex] = nums[moveUpIndex + k - 1];
                    if (moveUpIndex == 0)
                    {
                        nums[k - 1] = lastElement;

                        if (k == 1) return;

                        int newK = (k - 2) - (elementToMove - 2) % (k - 1);
                        elementToMove = k - 1;
                        k = newK;
                    }
                }
            }
        }
        public static bool IsHappy(int n)
        {
            int[] preSumArray = Enumerable.Repeat(0, 10).ToArray();

            int sum = 0;
            int r;

            while (true)
            {
                r = n % 10;
                sum += r * r;

                n /= 10;
                if (n == 0)
                {
                    if (sum == 1)
                    {
                        return true;
                    }
                    else
                    {
                        if (sum < 10)
                        {
                            if (preSumArray[sum] != 0)
                            {
                                return false;
                            }
                            else
                                preSumArray[sum] = sum;
                        }

                        n = sum;
                        sum = 0;
                    }
                }
            }
        }

        static public string RemoveDuplicateLettersTwo(string inputString)
        {
            //cbacdcbc
            if (inputString == null || inputString.Length == 0)
                return null;

            const int TOTAL_LETTERS = 26;

            int[] letterCount = new int[TOTAL_LETTERS];
            int[] letterToKeep = new int[TOTAL_LETTERS];
            int[] currentLetterPos = new int[TOTAL_LETTERS];

            for (int i = 0; i < inputString.Length; i++)
            {
                letterCount[inputString[i] - 'a']++;
            }


            int[][] letterOccurances = new int[TOTAL_LETTERS][];
            for (int i = 0; i < letterCount.Length; i++)
            {
                //Is array with 0 element OK;
                letterOccurances[i] = new int[letterCount[i]];
            }

            for (int i = 0; i < inputString.Length; i++)
            {
                int letterSeq = inputString[i] - 'a';
                letterOccurances[letterSeq][currentLetterPos[letterSeq]] = i;
                currentLetterPos[letterSeq]++;
            }


            //cbacdcbc
            for (int i = 0; i < TOTAL_LETTERS; i++) //26 letters
            {
                //b
                letterToKeep[i] = letterOccurances[i].Length == 0 ? -1 : letterOccurances[i][0]; //break?


                for (int k = 0; k < letterOccurances[i].Length; k++) //letter[j] occurances
                {
                    for (int j = 0; j < i; j++)//letter before letter[i]
                    {
                        if (letterOccurances[i][k] > letterToKeep[j]) //b is behid a
                        {
                            letterToKeep[i] = letterOccurances[i][k]; //move current, final
                            break;
                        }
                    }

                    if (letterToKeep[i] == -1) //?
                    {
                        letterToKeep[i] = letterOccurances[i][0]; // pointer move
                    }
                }
            }

            StringBuilder sb = new StringBuilder(26);

            for (int i = 0; i < inputString.Length; i++)
            {
                if (i == letterToKeep[inputString[i] - 'a'])
                {
                    sb.Append(inputString[i]);
                }
            }

            return sb.ToString();

        }


        ////a
        //for (int j = 0; j < i; j++)//letter before letter[i]
        //{
        //    for (int k = tempPointer; k < letterOccurances[i].Length; k++) //letter[j] occurances
        //    {
        //        if(letterOccurances[i][k] > letterToKeep[j]) //b is behid a
        //        {
        //            letterToKeep[i] = letterOccurances[i][k]; //move current, final
        //            tempPointer = k;
        //            break;
        //        }
        //    }

        //    if(letterToKeep[i] == -1) //?
        //    {
        //        letterToKeep[i] = letterOccurances[i][0]; // pointer move
        //    }

        static public string RemoveDuplicateLettersOne(string s)
        {
            int[] letterCount = new int[26];
            int[] letterToKeep = new int[26];

            for (int i = 0; i < letterToKeep.Length; i++)
            {
                letterToKeep[i] = -1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                letterCount[s[i] - 'a'] += 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                //already which one to keep
                if (letterToKeep[s[i] - 'a'] != -1) continue;

                // "cbacdcbc"
                letterToKeep[s[i] - 'a'] = i;
                bool skipTillNextOne = false;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (skipTillNextOne && s[i] != s[j])
                        continue;

                    if (s[i] == s[j])
                    {
                        letterCount[s[i] - 'a']--;
                        letterToKeep[s[i] - 'a'] = j;

                        if (letterCount[s[i] - 'a'] == 1)
                            break;

                        skipTillNextOne = false;
                        continue;

                    }


                    if (s[i] > s[j])
                    {
                        skipTillNextOne = true;
                    }
                    else if (s[i] < s[j] &&
                        (letterToKeep[s[j] - 'a'] == -1 ||
                            letterToKeep[s[j] - 'a'] == j))
                    {
                        break;
                    }

                }
            }


            StringBuilder sb = new StringBuilder(26);

            for (int i = 0; i < s.Length; i++)
            {
                if (i == letterToKeep[s[i] - 'a'])
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
