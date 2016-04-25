using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class SubsetSum
    {
        int[] weights;
        List<List<int>> tupletList;
        public SubsetSum(int[] weights)
        {
            this.weights = weights;
            this.tupletList = new List<List<int>>();
        }
        public List<List<int>> GenerateSubsets(int targetSum)
        {
            GenerateSubsetsUtil(0, new List<int>(), targetSum);

            return tupletList;
        }
        public void GenerateSubsetsUtil(int wIndex, List<int> tuplet, int targetSum)
        {
            for (int i = wIndex; i < weights.Length && tuplet.Count <= 3 && i <= weights.Length - (3 - tuplet.Count); i++)
            {
                tuplet.Add(weights[i]);

                 if (tuplet.Count == 3)
                {
                    if (targetSum == weights[i])
                    {
                        List<int> sol = new List<int>(tuplet);
                        this.tupletList.Add(sol);
                    }
                }
                else
                {
                    GenerateSubsetsUtil(i + 1, tuplet, targetSum - weights[i]);
                }

                tuplet.RemoveAt(tuplet.Count - 1);
            }

        }

    }
}
