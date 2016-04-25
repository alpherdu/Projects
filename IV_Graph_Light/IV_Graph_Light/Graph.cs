using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Graph_Light
{
    public class Graph
    {
        private int V;
        private List<int>[] adj;

        public Graph(int V)
        {
            this.V = V;
            adj = new List<int>[V];
        }

        public void AddVertex(int v)
        {
            if (this.adj[v] == null) this.adj[v] = new List<int>();
        }

        public void AddEdge(int v, int w)
        {
            AddVertex(v);
            this.adj[v].Add(w);
        }

        public IEnumerable<int[]> Edges()
        {
            for (int i = 0; i < this.V; i++)
            {
                foreach (var item in this.adj[i])
                {
                    yield return new int[] { i, item };
                }
            }

        }

        public List<int> TopologicalSort(ref bool cycle)
        {
            Stack<int> s = new Stack<int>();

            bool[] visited = new bool[this.V]; //defalut value is false;
            bool[] onStack = new bool[this.V]; //defalut value is false;

            for (int i = 0; i < this.V; i++)
                if (!visited[i]) TopologicalSortUtil(s, visited, onStack, i, ref cycle);

            return s.ToList();
        }

        private void TopologicalSortUtil(Stack<int> s, bool[] visited, bool[] onStack, int v, ref bool cycle)
        {
            if (this.adj[v] == null) return; //bug: this line was missing

            visited[v] = true;

            onStack[v] = true;
            int w = -1;
            for (int i = 0; i < this.adj[v].Count; i++)
            {
                w = this.adj[v][i];

                if (onStack[w]) { cycle = true; }
                else if (!visited[w]) TopologicalSortUtil(s, visited, onStack, w, ref cycle);
            }
            onStack[v] = false;

            if (w != -1 && adj[w] == null) s.Push(w);//bug: this line was missing

            s.Push(v);
        }
    }
}
