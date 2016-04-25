using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_SegmentTree
{
    public class SegmentTree
    {
        private int[] arrayST;
        private int len;
        public SegmentTree(int[] array)
        {
            this.len = array.Length;
            this.arrayST = new int[2 * len]; //never use arrayST[0]; 0 + internal (n-1) + leave( n);

            for (int i = 0; i < len; i++) arrayST[len + i] = array[i];

            for (int j = len - 1; j >= 1; j--) arrayST[j] = arrayST[2 * j] + arrayST[2 * j + 1];
        }

        public void Modify(int index, int val)
        {
            if (index < 0 || index >= len) return;

            int delta = val - arrayST[len + index];

            index = index + len; //bug: forgot to transform index
            for (int i = index; i >= 1; i >>= 1) arrayST[i] += delta;
        }

        public int Query(int start, int end)// sum on interval [l, r]
        {
            start += len;
            end += len;

            int result = 0;
            while (start <= end)
            {
                if (start % 2 == 1) result += arrayST[start];
                if (end % 2 == 0) result += arrayST[end];

                //move beyond the elment already taken care at this level
                start++;
                end--;

                //move up one level
                start >>= 1;
                end >>= 1;
            }
            return result;
        }
    }
}
