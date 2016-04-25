using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set25_SubsetSumProblem
    {
        public bool IsSubsetSum_Recursive(int[] arr, int L, int sum)
        {
            if (sum == 0) return true;
            else if (sum < 0) return false;

            if (L == 0) return sum == 0;

            return IsSubsetSum_Recursive(arr, L - 1, sum) || IsSubsetSum_Recursive(arr, L - 1, sum - arr[L - 1]);
        }
    }
}
