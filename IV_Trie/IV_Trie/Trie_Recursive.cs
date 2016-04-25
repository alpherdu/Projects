using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Trie
{
    public partial class Trie
    {
        public void Insert_Recursive(TrieNode node, string word)
        {
            node.isLeaf = false;

            int childPos = word[0] - 'a';
            if (node.children[childPos] == null)
            {
                node.children[childPos] = new TrieNode(word[0]);
            }

            if (word.Length == 1)
                node.children[childPos].isWord = true;
            else
                Insert_Recursive(node.children[childPos], word.Substring(1));
        }
        TrieNode FindLowestChildNode_Recursive(TrieNode node, string word)
        {
            TrieNode child = node.children[word[0] - 'a'];
            if (child == null) return null;
            else if (word.Length == 1) return child;
            else return FindLowestChildNode(node, word.Substring(1));
        }

    }
}
