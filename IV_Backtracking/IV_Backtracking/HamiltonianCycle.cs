using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class HamiltonianCycle
    {
        int[,] graph;
        HashSet<int> path; //HashSet is a good choice, because each node needs to be visited once and only once.

        public HamiltonianCycle(int[,] graph)
        {
            this.graph = graph;
            this.path = new HashSet<int>();
        }

        public bool SolveIt()
        {
            path.Add(0);
            return SolveItUtil(0);
        }

        private bool SolveItUtil(int curV)
        {
            if (path.Count == graph.GetLength(0)) return graph[curV, 0] == 1;

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (graph[curV, i] == 1 && !path.Contains(i))
                {
                    path.Add(i);
                    if(SolveItUtil(i)) return true;
                    path.Remove(i);
                }
            }

            return false;
        }
    }
}
