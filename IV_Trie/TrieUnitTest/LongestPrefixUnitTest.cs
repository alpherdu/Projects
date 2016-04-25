using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Trie;
namespace TrieUnitTest
{
    [TestClass]
    public class LongestPrefixUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trie trie = new Trie();
            trie.Insert("are");
            trie.Insert("area");
            trie.Insert("base");
            trie.Insert("cat");
            trie.Insert("cater");
            trie.Insert("basement");

            String input = "caterer";
            System.Diagnostics.Debug.Write(input + ":   ");
            System.Diagnostics.Debug.WriteLine(trie.FindLongestPrefix(input));

            input = "basement";
            System.Diagnostics.Debug.Write(input + ":   ");
            System.Diagnostics.Debug.WriteLine(trie.FindLongestPrefix(input));

            input = "are";
            System.Diagnostics.Debug.Write(input + ":   ");
            System.Diagnostics.Debug.WriteLine(trie.FindLongestPrefix(input));

            input = "arex";
            System.Diagnostics.Debug.Write(input + ":   ");
            System.Diagnostics.Debug.WriteLine(trie.FindLongestPrefix(input));

            input = "basemexz";
            System.Diagnostics.Debug.Write(input + ":   ");
            System.Diagnostics.Debug.WriteLine(trie.FindLongestPrefix(input));

            input = "xyz";
            System.Diagnostics.Debug.Write(input + ":   ");
            System.Diagnostics.Debug.WriteLine(trie.FindLongestPrefix(input));
        }
    }
}
