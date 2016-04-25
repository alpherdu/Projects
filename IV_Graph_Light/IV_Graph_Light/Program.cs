using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Graph_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = { "wrt", "wrf", "er", "ett", "rftt" };
            //string[] words = { "z", "z" };
            //string[] words = { "wnlb" };
            //string[] words = { "zy", "zx" };
            string[] words = { "ab", "adc" };
            //string[] words = { "a", "ac" };

            Graph graph = new Graph(26);
            BuildEdges(words, 0, words.Length - 1, 0, graph);

            bool cycle = false;
            List<int> list = graph.TopologicalSort(ref cycle);

            StringBuilder sb = new StringBuilder(list.Count);
            foreach (var item in list) sb.Append((char)('a' + item));

            var x = sb.ToString();

        }
        public static void BuildEdges(string[] words, int sIndex, int eIndex, int curPos, Graph graph)
        {
            List<string> wordList = new List<string>();
            for (int i = sIndex; i <= eIndex; i++)
            {
                if (words[i].Length > curPos) wordList.Add(words[i]);
            }
            if (wordList.Count == 0) graph.AddVertex(words[sIndex][curPos - 1] - 'a');
            if (wordList.Count == 1) foreach (var item in wordList[0]) graph.AddVertex(item - 'a');
            if (wordList.Count < 2) return;

            sIndex = 0;
            for (int i = sIndex + 1; i < wordList.Count; i++)
            {
                if (wordList[sIndex][curPos] != wordList[i][curPos])
                {
                    graph.AddEdge(wordList[sIndex][curPos] - 'a', wordList[i][curPos] - 'a');

                    if (sIndex < i - 1)
                    {
                        BuildEdges(wordList.ToArray(), sIndex, i - 1, curPos + 1, graph);
                    }
                    sIndex = i;
                }
            }
            if (sIndex == 0) graph.AddVertex(words[sIndex][curPos] - 'a');
            if (sIndex < wordList.Count - 1)
            {
                BuildEdges(wordList.ToArray(), sIndex, wordList.Count - 1, curPos + 1, graph);
            }
        }
    }
}
