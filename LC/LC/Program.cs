using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 2, 3, 1 };

            Program p = new Program();
            var x = p.VerifyPreorder(nums);

        }

        public bool VerifyPreorder(int[] preorder)
        {
            if (preorder == null || preorder.Length == 0) return true;

            return VerifyPreorder(preorder, 0, preorder.Length - 1, int.MinValue, int.MaxValue);
        }

        bool VerifyPreorder(int[] nums, int start, int end, int min, int max)
        {
            if (start >= end) return true; //bug: ==

            int rRootIndex = -1;
            for (int i = start + 1; i <= end; i++)
            {
                if (nums[i] < min || nums[i] > max) return false;

                if (rRootIndex == -1 && nums[i] > nums[start])
                {
                    rRootIndex = i;
                }
            }
            if (rRootIndex == -1) rRootIndex = end + 1;

            return VerifyPreorder(nums, start + 1, rRootIndex - 1, min, nums[start]) &&
                        VerifyPreorder(nums, rRootIndex, end, nums[start], max);
        }
    }
}
