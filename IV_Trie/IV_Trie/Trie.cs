using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Trie
{
    public partial class Trie
    {
        private readonly TrieNode root = new TrieNode(' ');

        public void Insert(string word)
        {
            Insert(root, word);
        }
        public bool SearchWord(string word)
        {
            return SearchWord(root, word);
        }

        public void DeleteKey(string word)
        {
            int len = word.Length;

            if (len > 0)
            {
                DeleteKeyUtil(root, word, 0);
            }
        }

        void DeleteKeyUtil(TrieNode parent, string word, int level)
        {
            TrieNode childToBeDel = parent.children[word[level] - 'a'];

            if (level == word.Length - 1)
            {
                if (childToBeDel.isLeaf)
                {
                    parent.children[word[level] - 'a'] = null;
                    UpdateIsLeaf(parent);
                }
                else childToBeDel.isWord = false; //no need to check if it is a word
            }
            else
            {
                DeleteKeyUtil(childToBeDel, word, level + 1);
                
                if(childToBeDel.isLeaf && !childToBeDel.isWord)
                {
                    parent.children[word[level] - 'a'] = null;
                    UpdateIsLeaf(parent);
                }
            }
        }

        void UpdateIsLeaf(TrieNode node)
        {
            foreach (TrieNode aNode in node.children)
            {
                if (aNode != null) return;
            }

            node.isLeaf = true;
        }

        public List<string> KeysWithPrefix(String prefix, bool isWord)
        {
            List<string> results = new List<string>();

            TrieNode x = root;
            if(prefix != string.Empty) x = FindLowestChildNode(root, prefix);
            collect(x, new StringBuilder(prefix), results, isWord);

            return results;
        }

        private void collect(TrieNode node, StringBuilder prefix, List<string> results, bool isWord)
        {
            if (node == null) return;

            if( !isWord || node.isWord) results.Add(prefix.ToString());

            foreach (var item in node.children)
            {
                if (item == null) continue;
                prefix.Append(item.val);
                collect(node.children[item.val - 'a'], prefix, results, isWord);
                prefix.Remove(prefix.Length - 1,1);
            }

        }
        private void Insert(TrieNode node, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                node.isLeaf = false;

                int childPos = word[i] - 'a';
                if (node.children[childPos] == null)
                {
                    node.children[childPos] = new TrieNode(word[i]);
                }

                TrieNode curChild = node.children[childPos];

                if (i == word.Length - 1)
                {
                    curChild.isWord = true;
                    return;
                }
                else
                    node = curChild;
            }
        }

        private TrieNode FindLowestChildNode(TrieNode node, string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                TrieNode child = node.children[word[i] - 'a'];
                if (child == null) break;
                else if (i == word.Length - 1) return child;
                else node = child;
            }

            return null;
        }

        public string FindLongestPrefix(string word)
        {
            return FindLongestPrefix(root, word);
        }
        private string FindLongestPrefix(TrieNode node, string word)
        {
            int maxIndex = -1;
            for (int i = 0; i < word.Length; i++)
            {
                TrieNode child = node.children[word[i] - 'a'];
                if (child == null) break;
                else if (child.isWord) maxIndex = i;

                node = child;
            }

            return maxIndex == -1 ? string.Empty : word.Substring(0, maxIndex);
        }
        private bool SearchWord(TrieNode node, string word)
        {
            TrieNode lowestNode = FindLowestChildNode(node, word);
            return lowestNode != null && lowestNode.isWord;
        }

        private bool StartsWith(TrieNode node, string prefix)
        {
            TrieNode lowestNode = this.FindLowestChildNode(node, prefix);

            return lowestNode != null;// && !lowestNode.isLeaf;
        }

    }
}
