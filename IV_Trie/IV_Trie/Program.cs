using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            IV_Trie.Trie trie = new Trie();
            string[] keys = { "the", "a", "there", "answer", "any", "by", "bye", "their" };
            for (int i = 0; i < keys.Length; i++)
            {
                trie.Insert(keys[i]);
            }


            List<string> list = trie.KeysWithPrefix("", true);
        }
    }
}
