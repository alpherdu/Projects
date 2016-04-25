using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Trie
{
    public class TrieNode
    {
        private static int R = 26;

        public char val;
        public bool isWord;
        public bool isLeaf;
        public TrieNode[] children;

        public TrieNode(char val)
        {
            this.val = val;
            this.isLeaf = true;
            this.isWord = false;
            this.children = new TrieNode[R];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.val + ",");
            sb.Append("isLeaf:" + isLeaf + ",");
            sb.Append("isword:" + isWord + ",") ;
            sb.Append("--->");
            foreach (var item in children)
            {
                if(item != null)sb.Append(item.val + ",");
            }
            return sb.ToString();
        }
    }
}
