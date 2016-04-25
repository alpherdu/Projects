using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {

            List<IList<int>> result = new List<IList<int>>();
            List<int> preList = new List<int>();
            
            PermuteUtil(preList, nums.ToList(), result);

            return result;
        }

        void PermuteUtil(List<int> preList, List<int> list, List<IList<int>> result)
        {
            if (list.Count == 0) result.Add(preList);

            list.Sort();
                        
            for (int i = 0; i < list.Count; i++)
            {
                if (i != 0 && list[i] == list[i - 1]) continue;

                preList.Add(list[i]);
                List<int> newList = new List<int>(list.ToArray());
                newList.RemoveAt(i);
                PermuteUtil(preList, newList, result);

                preList.RemoveAt(preList.Count - 1);

            }
        }
    }
}
