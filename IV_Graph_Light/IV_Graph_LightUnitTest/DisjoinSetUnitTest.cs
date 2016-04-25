using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Graph_Light;

namespace IV_Graph_LightUnitTest
{
    [TestClass]
    public class DisjoinSetUnitTest
    {
        [TestMethod]
        public void NaiveTestMethod1()
        {
            int V = 3;
            Graph graph = new Graph(V);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);

            DisjointSet_Naive djs = new DisjointSet_Naive(V);
            var x = djs.ISCycle(graph);            
        }

        [TestMethod]
        public void RankTestMethod1()
        {
            int V = 3;
            Graph graph = new Graph(V);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);

            DisjointSetRank djs = new DisjointSetRank(V);
            var x = djs.ISCycle(graph);
        }

    }
}
