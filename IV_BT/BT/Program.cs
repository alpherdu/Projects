using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            int[] nums = { -1, 2147483647 };

            int r;

            var y = -7;
            y %= 10;

            p.Reverse(1);

            var x = p.IsPalindrome(103301);

    }

        public int Reverse(int x)
        {
            int result = 0;
            int temp;
            while (x != 0)
            {
                temp = result * 10 + x % 10;
                if (result != (temp - (x % 10)) / 10) return 0;

                x /= 10;
            }

            return result;
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0 || x % 10 == 0) return false;

            int pal = 0;
            while( pal < x)
            {
                pal = pal * 10 + x % 10;
                x = x / 10;
            }

            return (x == pal || x == pal / 10);


        }

        public int CountPrimes(int n)
        {
            if (n <= 2) return 0;

            int[] nums = new int[n + 1];

            for (int i = 1; i <= n; i++) nums[i] = i;

            int curPrime = 2;
            int curNum;
            int primeCounter = 1;
            while (true)
            {
                curNum = curPrime;
                while (curNum < n)
                {
                    nums[curNum] = 0;
                    curNum += curPrime;
                }

                bool foundNextPrime = false;
                for (int i = curPrime; i < n; i++)
                {
                    if (nums[i] != 0)
                    {
                        curPrime = nums[i];
                        primeCounter++;
                        foundNextPrime = true;
                        break;
                    }
                }

                if (!foundNextPrime) break;

            }

            return primeCounter;
        }


        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (nums == null || nums.Length == 0) return false;

            Hashtable ht = new Hashtable();

            for (int i = 0; i < (k + 1) && i < nums.Length; i++)
            {
                if (ht.ContainsKey(Math.Abs(t - nums[i])))
                    return true;
                else
                    ht[nums[i]] = ht[nums[i]] == null ? 0 : (int)ht[nums[i]];
            }

            for (int i = (k + 1); i < nums.Length; i++)
            {
                ht.Remove(nums[i - (k + 1)]);

                if (ht.ContainsKey(Math.Abs(t - nums[i])))
                    return true;
                else
                    ht[nums[i]] = ht[nums[i]] == null ? 0 : (int)ht[nums[i]];
            }

            return false;
        }
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0) return false;

            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < (k + 1) && i < nums.Length; i++)
            {
                if (!hs.Add(nums[i])) return true;
            }

            for (int i = k + 1; i < nums.Length; i++)
            {
                hs.Remove(nums[i - (k + 1)]);
                if (!hs.Add(nums[i])) return true;
            }

            return false;
        }
        static public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

            char[] key;
            for (int i = 0; i < strs.Count(); i++)
            {
                key = strs[i].ToArray();
                Array.Sort(key);
                string s = new string(key);
                if (dict.ContainsKey(s))
                {
                    dict[s].Add(strs[i]);
                }
                else
                {
                    IList<string> list = new List<string>();
                    list.Add(strs[i]);
                    dict.Add(s, list);
                }
            }

            foreach (List<string> aList in dict.Values)
            {
                aList.Sort();
                result.Add(aList);
            }

            return result;

        }

        static public IList<IList<string>> GroupAnagrams_Slow(string[] strs)
        {
            IList<IList<string>> combinedList = null;

            IList<IList<string>> groupByLength = GroupByLength(strs);
            for (int i = 0; i < groupByLength.Count(); i++)
            {
                IList<IList<string>> x = GroupAnagramsUtil(groupByLength[i].ToArray());

                if (combinedList == null) combinedList = x;
                else
                {
                    for (int j = 0; j < x.Count(); j++)
                    {
                        combinedList.Add(x[j]);
                    }
                }

            }

            return combinedList;
        }

        static public IList<IList<string>> GroupByLength(string[] strs)
        {
            Dictionary<int, IList<string>> dict = new Dictionary<int, IList<string>>();

            for (int i = 0; i < strs.Count(); i++)
            {
                int len = strs[i].Length;
                if (!dict.ContainsKey(len))
                {
                    IList<string> list = new List<string>();
                    list.Add(strs[i]);
                    dict.Add(len, list);
                }
                else
                {
                    dict[len].Add(strs[i]);
                }
            }

            return dict.Values.ToList();
        }

        static public IList<IList<string>> GroupAnagramsUtil(string[] strs)
        {
            if (strs == null || strs.Length == 0) return new List<IList<string>>();

            Array.Sort(strs);

            int[] ht;
            IList<int[]> htList = new List<int[]>();
            for (int i = 0; i < strs.Length; i++)
            {
                ht = new int[27];
                for (int j = 0; j < strs[i].Length; j++)
                {
                    ht[strs[i][j] - 'a']++;
                }
                ht[26] = i; // index of the strs;
                htList.Add(ht);
            }

            IList<string> anagramList = new List<String>();
            IList<IList<string>> resultList = new List<IList<string>>();

            do
            {
                anagramList = new List<String>();
                int[] firstHt = htList[0];
                anagramList.Add(strs[firstHt[26]]);
                htList.RemoveAt(0);

                for (int i = 0; i < htList.Count(); i++)
                {
                    int[] curHt = htList[i];
                    bool isAnagram = true;
                    if (strs[firstHt[26]].Length != strs[curHt[26]].Length)
                    {
                        isAnagram = false;
                    }
                    else
                    {
                        for (int j = 0; j < 26; j++)
                        {
                            if (firstHt[j] != curHt[j])
                            {
                                isAnagram = false;
                                break;
                            }
                        }
                    }
                    if (isAnagram)
                    {
                        anagramList.Add(strs[curHt[26]]);
                        htList.RemoveAt(i);
                        i--; //after remove one ht, the index stay
                    }
                }

                resultList.Add(anagramList);
            } while (htList.Count() > 0); // NOT greater than 1

            return resultList;
        }

        static public string GetPermutation(int n, int k)
        {
            if (n < 1 || n > 20 || k <= 0) return string.Empty;

            IList<int> source = new List<int>();
            IList<int> picked = new List<int>();

            int chuck = 1;
            for (int i = 1; i <= n; i++)
            {
                chuck *= i;
                source.Add(i);
            }

            k = k - 1; // convert to 0-based

            int pickedPos;
            for (int j = n; j >= 1; j--)
            {
                chuck = chuck / j;

                pickedPos = k / chuck;
                picked.Add(source[pickedPos]);
                source.RemoveAt(pickedPos);

                k = k % chuck;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < picked.Count(); i++) sb.Append(picked[i]);

            return sb.ToString();
        }

        static public string CountAndSay(int n)
        {
            if (n <= 0) return null;

            List<int> list = new List<int>();
            list.Add(1);

            // sixteen 2, should be two numbers, 16 and 2?
            //or three numbers, 1, 6 and 2?(YES)

            int curNumberCount;
            int preNumsCount;
            for (int i = 2; i <= n; i++)
            {
                preNumsCount = list.Count;
                for (int j = 0; j < preNumsCount; j++)
                {
                    curNumberCount = 1;
                    for (int k = j + 1; k < preNumsCount; k++)
                    {
                        if (list[j] == list[k]) curNumberCount++;
                        else break;
                    }

                    list.Add(curNumberCount);
                    if (curNumberCount > 9)
                    {
                        Console.WriteLine();
                    }
                    list.Add(list[j]);

                    j = j + curNumberCount - 1; // j-for loop will increase j by one;
                }

                for (int j = 0; j < preNumsCount; j++) list.RemoveAt(0);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
            }

            return sb.ToString();
        }
        static public IList<string> LetterCombinations(string digits)
        {
            if (digits == null || digits.Length == 0) return new List<string>();

            IList<string> resultList = new List<string>();

            string[] numMapping = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };


            string curDigit = digits[0].ToString();
            int numValue;
            if (!Int32.TryParse(curDigit, out numValue)) return null;

            IList<string> restStrings = null;

            for (int i = 0; i < numMapping[numValue].Length; i++)
            {
                if (digits.Length == 1)
                {
                    resultList.Add(numMapping[numValue][i].ToString());
                }
                else
                {
                    restStrings = LetterCombinations(digits.Substring(1, digits.Length - 1));
                    for (int j = 0; j < restStrings.Count; j++)
                    {
                        resultList.Add(numMapping[numValue][i] + restStrings[j]);
                    }
                }
            }

            return resultList;
        }
    }
}
