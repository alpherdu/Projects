using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IV_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph;
            string fileName = @"..\..\tiny.txt";
            using (TextReader reader = File.OpenText(fileName))
            {
                graph = Graph.CreateGraph(reader);
            }
        }
    }
}
