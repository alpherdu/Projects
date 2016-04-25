using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Graph_Light
{
    public class DisjointSet_Naive
    {
        int[] parent;

        public DisjointSet_Naive(int V)
        {
            this.parent = new int[V];
            for (int i = 0; i < V; i++) MakeSet(i);
        }

        void MakeSet(int i)
        {
            parent[i] = i;
        }

        int Find(int i)
        {
            if (parent[i] == i) return i;
            else return Find(parent[i]);
        }

        void Union(int x, int y)
        {
            int xSet = Find(x);
            int ySet = Find(y);

            parent[xSet] = ySet;
        }

        public bool ISCycle(Graph graph)
        {
            foreach (var edge in graph.Edges())
            {
                int xRoot = Find(edge[0]);
                int YRoot = Find(edge[1]);

                if (xRoot == YRoot) return true;

                Union(xRoot, YRoot);
            }

            return false;
        }
    }
}
