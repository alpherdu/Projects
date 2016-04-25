using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Graph
{
    public enum Color
    {
        Whilte,
        Gray,
        Balck
    };

    public class Vertex
    {
        public int Value { set; get; }
        public Color Color { set; get; }
        public int Depth { set; get; }
        public Vertex Parent { set; get; }
        public Dictionary<int, int> Adj { set; get; }
    }
}
