using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Graph_Light
{
    public class DisjointSetRank
    {
        int[] parent;
        int[] rank;

        public DisjointSetRank(int V)
        {
            this.rank = new int[V];

            this.parent = new int[V];
            for (int i = 0; i < V; i++) MakeSet(i);
        }

        void MakeSet(int i)
        {
            parent[i] = i;
        }

        int Find(int i)
        {
            if (parent[i] != i) parent[i] = Find(parent[i]);

            return parent[i];
        }

        void Union(int x, int y)
        {
            int xRoot = Find(x);
            int yRoot = Find(y);

            if (xRoot == yRoot) return;

            // x and y are not in the same set. merge them.
            if (rank[xRoot] == rank[yRoot])
            {
                rank[xRoot]++;
                parent[yRoot] = xRoot;
            }
            else if (rank[xRoot] > rank[yRoot])
                parent[yRoot] = xRoot;
            else
                parent[xRoot] = yRoot;

            rank[xRoot] = rank[yRoot];
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
