using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class LongestPalindromicSubsequenceUnitTest
    {
        [TestMethod]
        public void LPS_Recursive_TestMethod()
        {
            char[] array = "BBABCBCAB".ToCharArray();
            var x = IV.LongestPalindromicSubsequence.LPS_Recursive(array);

            Assert.AreEqual(7, x);
        }

        [TestMethod]
        public void LPS_DP_TestMethod()
        {
            //string s = "adam";
            string s = "GEEKSFORGEEKS";
            var x = IV.LongestPalindromicSubsequence.LPS_DP(s);

            Assert.AreEqual(5, x.Length);
        }

        [TestMethod]
        public void LPS_DP_LongStringTestMethod()
        {
            //string s = "adam"; // "GEEKSFORGEEKS";
            string s = System.IO.File.ReadAllText(@"..\..\input.txt");

            var x = IV.LongestPalindromicSubsequence.LPS_DP(s);

            Assert.AreEqual(397, x.Length); //not sure if 397 is the right length
        }

        [TestMethod]
        public void LPS_DP_SameChar_ODD_TestMethod()
        {
            string s = "YYY";
            var x = IV.LongestPalindromicSubsequence.LPS_DP(s);

            Assert.AreEqual(3, x.Length);
        }

        [TestMethod]
        public void LPS_DP_SameChar_Even_TestMethod()
        {
            string s = "YYYY";
            var x = IV.LongestPalindromicSubsequence.LPS_DP(s);

            Assert.AreEqual(4, x.Length);
        }

        [TestMethod]
        public void LPS_DP_Input_All_A_ExceptTwo_TestMethod()
        {
            //string s = "adam"; // "GEEKSFORGEEKS";
            string s = System.IO.File.ReadAllText(@"..\..\Input_All_A_ExceptTwo.txt");

            var x = IV.LongestPalindromicSubsequence.LPS_DP(s);

            Assert.AreEqual(998, x.Length);
        }
    }
}
