using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class MColoring
    {
        int[,] graph;
        int maxColors;
        int[] color;
        public MColoring(int[,] graph, int maxColors)
        {
            this.graph = graph;
            this.maxColors = maxColors;
            this.color = new int[graph.GetLength(0)];
        }

        public bool SolvIt()
        {
            return SolvItUtil(0);
        }
        private bool SolvItUtil(int curV)
        {
            if (curV == graph.GetLength(0)) return true;

            for (int colorOption = 1; colorOption < maxColors + 1; colorOption++) // 1 - based, 0 is reserved for unassigned 
            {
                color[curV] = colorOption;
                if (IsSafe(color, curV) && SolvItUtil(curV + 1)) return true;
                color[curV] = 0;
            }

            return false;
        }

        private bool IsSafe(int[] color, int curV)
        {
            for (int i = 0; i < graph.GetLength(0); i++)
                if (graph[curV, i] == 1 && color[curV] == color[i]) return false;

            return true;
        }

    }
}
