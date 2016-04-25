using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class GenerateParentheses
    {
        int nPairs;
        int[] counters = new int[2];
        List<string> results = new List<string>();

        public List<string> SolveIt(int nPairs)
        {
            this.nPairs = nPairs;//bug: forgot to init
            counters[0] = nPairs;
            counters[1] = nPairs;

            return SolveItUtil(new StringBuilder());
        }

        private List<string> SolveItUtil(StringBuilder aResult)
        {
            if (aResult.Length == nPairs * 2)
            {
                if (counters[0] == counters[1]) // bug: not check remainings are balanced.
                    results.Add(aResult.ToString());
            }
            else
            {
                for (int key = 0; key < counters.Length; key++)
                {
                    if (IsSafe(key))
                    {
                        counters[key]--;
                        aResult.Append(key == 0 ? '(' : ')');
                        SolveItUtil(aResult);
                        aResult.Remove(aResult.Length - 1, 1);
                        counters[key]++;
                    }
                }
            }

            return results;
        }

        bool IsSafe(int key)
        {
            if (counters[key] == 0) return false; //<0
            if (counters[0] == counters[1] && key == 1) return false;

            return true;
        }
    }
}
