using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "abc";

            for (int i = 0; i <= x.Length; i++)
            {
                var y = x.Substring(i);
                var z = x.Substring(0, i);
            }
            
        }
    }

  
}
