using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Graph
{
    public class Graph
    {
        public int V;
        private int E;
        private Dictionary<int, Dictionary<int, int>> adj;
        
        public Graph(int V)
        {
            this.V = V;
            this.adj = new Dictionary<int, Dictionary<int, int>>();
        }

        public static Graph CreateGraph(System.IO.TextReader reader)
        {
            Graph graph = new Graph(int.Parse(reader.ReadLine()));
            //graph.E = int.Parse(reader.ReadLine());

            string adjList;
            while ((adjList = reader.ReadLine()) != null)
            {
                string[] array = adjList.Split(',');

                int v = int.Parse(array[0]);
                for (int j = 1; j < array.Length; j++)
                {
                    int w = int.Parse(array[j]);
                    graph.AddEdge(v, w, 1);
                }
            }

            return graph;
        }
        public void AddEdge(int v, int w, int weight)
        {
            validateVertex(v);
            validateVertex(w);
            this.E++;
            if (!adj.ContainsKey(v))
                adj[v] = new Dictionary<int, int>();

            adj[v].Add(w, weight);
        }

        private void validateVertex(int v)
        {
            if (v < 0 || v >= this.V) throw new IndexOutOfRangeException();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(V + " vertices, " + E + " edges " + System.Environment.NewLine);

            foreach (KeyValuePair<int, Dictionary<int, int>> adjList in adj)
            {
                s.Append(adjList.Key + ": ");
                foreach (KeyValuePair<int, int> w in adjList.Value)
                {
                    s.Append(w.Key + ",");
                }
                s.Append(System.Environment.NewLine);
            }

            return s.ToString();
        }
    }

}
