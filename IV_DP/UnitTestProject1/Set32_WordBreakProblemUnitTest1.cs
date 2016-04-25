using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Set32_WordBreakProblemUnitTest1
    {
        string[] dictionary = {
                "mobile", "samsung", "sam", "sung", "man", "mango",
                "icecream", "and", "go", "i", "like", "ice", "cream" };

        [TestMethod]
        public void TestMethod1()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "";
            var x = wbp.wordBreak_Recursive(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "iiiiiiii";
            var x = wbp.wordBreak_Recursive(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void TestMethod3()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "ilikesamsung";
            var x = wbp.wordBreak_Recursive(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void TestMethod4()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "ilikelikeimangoiii";
            var x = wbp.wordBreak_Recursive(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void TestMethod5()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "samsungandmango";
            var x = wbp.wordBreak_Recursive(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void TestMethod6()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "samsungandmangok";
            var x = wbp.wordBreak_Recursive(s, dictionary);

            Assert.AreEqual(false, x);
        }

        [TestMethod]
        public void DP_TestMethod1()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "";
            var x = wbp.wordBreak_DP(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void DP_TestMethod2()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "iiiiiiii";
            var x = wbp.wordBreak_DP(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void DP_TestMethod3()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "ilikesamsung";
            var x = wbp.wordBreak_DP(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void DP_TestMethod4()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "ilikelikeimangoiii";
            var x = wbp.wordBreak_DP(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void DP_TestMethod5()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "samsungandmango";
            var x = wbp.wordBreak_DP(s, dictionary);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void DP_TestMethod6()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "samsungandmangok";
            var x = wbp.wordBreak_DP(s, dictionary);

            Assert.AreEqual(false, x);
        }

        [TestMethod]
        public void DP_TestMethod7()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "aaaaaaa";
            dictionary = new string[] { "aaaa", "aa" };
            var x = wbp.wordBreak_DP(s, dictionary);

            Assert.AreEqual(false, x);
        }

        [TestMethod]
        public void DP_TestMethod8()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "aaaaaaa";
            HashSet<string> wordDict = new HashSet<string>();
            wordDict.Add("aaaa");
            wordDict.Add("aa");

            var x = wbp.WordBreak_DP_Dict(s, wordDict);

            Assert.AreEqual(false, x);
        }


        [TestMethod]
        public void DP_TestMethod9()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "leetcode";

            HashSet<string> wordDict = new HashSet<string>();
            wordDict.Add("leet");
            wordDict.Add("code");

            var x = wbp.WordBreak_DP_Dict(s, wordDict);

            Assert.AreEqual(true, x);
        }

        [TestMethod]
        public void DP_TestMethod10()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "leetcode";

            HashSet<string> wordDict = new HashSet<string>();
            wordDict.Add("leet");
            wordDict.Add("code");

            var x = wbp.WordBreakII_DP_Dict(s, wordDict);

            Assert.AreEqual(1, x.Count);
        }

        [TestMethod]
        public void DP_TestMethod11()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "ilikeicecreamandmango";
            string[] dictionary = { "mobile","samsung","sam","sung","man","mango",
                           "icecream","and","go","i","like","ice","cream" };

            HashSet<string> wordDict = new HashSet<string>();
            foreach (var word in dictionary)
            {
                wordDict.Add(word);
            }

            var x = wbp.WordBreakII_DP_Dict(s, wordDict);

            Assert.AreEqual(4, x.Count);
        }

        [TestMethod]
        public void DP_TestMethod12()
        {
            IV.Set32_WordBreakProblem wbp = new IV.Set32_WordBreakProblem();
            string s = "ilikesamsungmobile";
            string[] dictionary = { "mobile","samsung","sam","sung","man","mango",
                           "icecream","and","go","i","like","ice","cream" };

            HashSet<string> wordDict = new HashSet<string>();
            foreach (var word in dictionary)
            {
                wordDict.Add(word);
            }

            var x = wbp.WordBreakII_DP_Dict(s, wordDict);

            Assert.AreEqual(2, x.Count);
        }
    }
}
