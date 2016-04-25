using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Trie;
using System.Collections.Generic;

namespace TrieUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Trie trie;

        [TestInitialize]
        public void Initialize()
        {
            this.trie = new Trie();
        }

        private void InsertKeys(string[] keys)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                trie.Insert(keys[i]);
            }
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {

            string[] keys = { "the", "a", "there", "answer", "any", "by", "bye", "their" };
            InsertKeys(keys);

            bool b;
            b = trie.SearchWord("the");
            Assert.AreEqual(true, b);

            b = trie.SearchWord("these");
            Assert.AreEqual(false, b);

            b = trie.SearchWord("their");
            Assert.AreEqual(true, b);

            b = trie.SearchWord("thaw");
            Assert.AreEqual(false, b);
        }


        [TestMethod]
        public void WordsStartWithTestMethod()
        {
            string[] keys = { "the", "a", "there", "answer", "any", "by", "bye", "their" };
            InsertKeys(keys);

            List<string> list = trie.KeysWithPrefix("th", true);
        }

        [TestMethod]
        public void KeysStartWithTestMethod()
        {
            string[] keys = { "the", "a", "there", "answer", "any", "by", "bye", "their" };
            InsertKeys(keys);

            List<string> list = trie.KeysWithPrefix("th", false);
        }

        [TestMethod]
        public void DeleteKeySingleTestMethod()
        {
            //string[] keys = { "she", "sells", "sea", "shore", "the", "by", "sheer" };

            string[] keys = { "she"};
            InsertKeys(keys);

            List<string> list;
            list = trie.KeysWithPrefix("s", true);

            this.trie.DeleteKey(keys[0]);

        }

        [TestMethod]
        public void DeleteKeySubPathTestMethod()
        {
            string[] keys = { "she", "sells", "sea", "shore", "the", "by", "sheer" };

            InsertKeys(keys);

            List<string> list;
            list = trie.KeysWithPrefix("s", true);

            this.trie.DeleteKey("she");
            list = trie.KeysWithPrefix("s", true);

        }

        [TestMethod]
        public void DeleteKeyLongPathTestMethod()
        {
            string[] keys = { "she", "sheer" };

            InsertKeys(keys);

            List<string> list;
            list = trie.KeysWithPrefix("s", true);

            this.trie.DeleteKey("sheer");
            list = trie.KeysWithPrefix("s", true);

            this.trie.DeleteKey("she");
            list = trie.KeysWithPrefix("s", true);
        }

    }
}
