using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Graph
{
    public class Edge : IComparable<Edge>
    {
        private int v;
        private int w;

        public Edge(int v, int w)
        {
            this.v = v;
            this.w = w;
        }

        public int CompareTo(Edge obj)
        {
            if (this.v > obj.v) return 1;
            if (this.v < obj.v) return -1;
            if (this.w > obj.w) return 1;
            if (this.w < obj.w) return -1;

            return 0;
        }

    }
}
