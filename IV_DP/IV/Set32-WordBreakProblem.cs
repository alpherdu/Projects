using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set32_WordBreakProblem
    {
        public bool wordBreak_Recursive(string s, string[] dictionary)
        {
            if (String.IsNullOrEmpty(s)) return true;
            if (dictionary == null || dictionary.Length == 0) return false;

            for (int L = 1; L <= s.Length; L++)
            {
                for (int j = 0; j < dictionary.Length; j++)
                {
                    if (s.Substring(0, L) == dictionary[j] &&
                        wordBreak_Recursive(s.Substring(L), dictionary)) return true;
                }
            }

            return false;
        }

        public bool WordBreak_DP_Dict(string s, ISet<string> wordDict)
        {
            if (String.IsNullOrEmpty(s)) return true;
            if (wordDict == null || wordDict.Count() == 0) return false;

            int[] dp = new int[s.Length + 1];
            int maxWordLen = 0;
            foreach (var word in wordDict)
                if (word.Length > maxWordLen) maxWordLen = word.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && dp[i] == 0) continue;

                for (int L = 1; L <= s.Length - i && L <= maxWordLen; L++)
                {
                    if (dp[i + L] == 0)
                    {
                        if (wordDict.Contains(s.Substring(i, L))) dp[i + L] = 1;
                    }
                }
            }

            return dp[s.Length] != 0;
        }


        public bool wordBreak_DP(string s, string[] dictionary)
        {
            if (String.IsNullOrEmpty(s)) return true;
            if (dictionary == null || dictionary.Length == 0) return false;

            int[,] dp = new int[s.Length + 1, dictionary.Length];//-1: potential, reached here by which word

            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && dp[i, 0] == 0) continue;
                for (int d = 0; d < dictionary.Length; d++)
                {
                    if (s.Substring(i).StartsWith(dictionary[d]))
                    {
                        dp[i, d] = d + 1;
                        int index = i + dictionary[d].Length;

                        if (index < s.Length + 1) dp[index, 0] = -(d + 1); //first element as a flag
                    }
                }
            }

            return dp[s.Length, 0] != 0;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //List of results
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public IList<string> WordBreakII_DP_Dict(string s, ISet<string> wordDict)
        {
            List<string> results = new List<string>();

            if (String.IsNullOrEmpty(s)) return results;
            if (wordDict == null || wordDict.Count() == 0) return results;


            int maxWordLen = 0; // optimizatoin, ealier bail out

            Dictionary<string, int> dictIndexer = new Dictionary<string, int>(); // 1- based, O(1) find word index
            string[] wordArray = wordDict.ToArray();
            for (int i = 0; i < wordArray.Length; i++)
            {
                dictIndexer.Add(wordArray[i], i + 1);

                if (wordArray[i].Length > maxWordLen) maxWordLen = wordArray[i].Length;
            }

            int[,] dp = new int[s.Length + 1, wordDict.Count() + 1]; //first column used as a flag of breakable
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = -1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && dp[i, 0] == -1) continue;

                for (int L = 1; L <= s.Length - i && L <= maxWordLen; L++)
                {
                    var x = s.Substring(i, L);
                    if (wordDict.Contains(x))
                    {
                        dp[i + L, 0] = 1;
                        dp[i + L, dictIndexer[x]] = i;
                    }
                }
            }

            return GenerateList(dp, wordArray, s.Length, "", results);
        }

        private IList<string> GenerateList(int[,] dp, string[] wordArray, int curStringStart, string aResult, IList<string> results)
        {
            if (curStringStart == 0)
            {
                results.Add(aResult);
            }
            else
            {
                for (int i = 1; i < dp.GetLength(1); i++)
                {
                    if (dp[curStringStart, i] != -1)
                    {
                        GenerateList(dp, wordArray, dp[curStringStart, i], wordArray[i - 1] + " " + aResult, results);
                    }
                }
            }

            return results;
        }
    }
}
