using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class TugWar
    {
        int N;
        int[] nums;
        long sum;
        long minDelta = int.MaxValue;

        List<int> selectedList = new List<int>();
        int[] seletecNumsResult;
        public int SolveIt(int[] nums)
        {
            this.N = nums.Length;
            this.nums = nums;
            this.sum = 0;
            for (int i = 0; i < nums.Length; i++) sum += nums[i];

            this.SolveItUtil(0, 0, 0);

            return (int)minDelta;
        }

        private void SolveItUtil(int selectNums, long selectedSum, int curIndex)
        {
            if (curIndex >= this.N || selectNums > (this.N + 1) / 2 ||
                (curIndex + 1 - selectNums) > (this.N + 1) / 2) return;

            if (selectNums == this.N / 2)
            {
                long delta = Math.Abs(sum - (selectedSum << 1));
                if (delta < minDelta)
                {
                    minDelta = delta;
                    this.seletecNumsResult = this.selectedList.ToArray();
                }
            }

            SolveItUtil(selectNums, selectedSum, curIndex + 1);

            this.selectedList.Add(nums[curIndex]);
            SolveItUtil(selectNums + 1, selectedSum + nums[curIndex], curIndex + 1);
            this.selectedList.Remove(nums[curIndex]);

        }
    }
}
