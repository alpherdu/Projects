using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_Graph_Light;
using System.Collections.Generic;

namespace IV_Graph_LightUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public int[] TestMethod1()
        {
            Graph graph = new Graph(6);

            graph.AddEdge(5, 2);
            graph.AddEdge(5, 0);
            graph.AddEdge(4, 0);
            graph.AddEdge(4, 1);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 1);

            bool cycle = false;
            List<int> list = graph.TopologicalSort(ref cycle);

            Assert.AreEqual(false, cycle);

            return new int[] { };

        }

        [TestMethod]
        public void TestMethod2()
        {
            Graph graph = new Graph(6);

            graph.AddEdge(5, 2);
            graph.AddEdge(5, 0);
            graph.AddEdge(4, 0);
            graph.AddEdge(4, 1);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 1);
            graph.AddEdge(1, 3);

            bool cycle = false;
            List<int> list = graph.TopologicalSort(ref cycle);

            Assert.AreEqual(true, cycle);
        }
    }
}
