using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_SegmentTree
{
    public delegate int RollUpDel(int num1, int num2);
    public class STDelegate
    {
        RollUpDel rollUpCallBack;

        private int[] arrayST;
        private int len;
        public STDelegate(int[] array, RollUpDel rollUpCallback)
        {
            this.rollUpCallBack = rollUpCallback;

            this.len = array.Length;
            this.arrayST = new int[2 * len]; //never use arrayST[0]; 0 + internal (n-1) + leave( n);

            for (int i = 0; i < len; i++) arrayST[len + i] = array[i];

            for (int j = len - 1; j >= 1; j--)
                arrayST[j] = rollUpCallback(arrayST[2 * j], arrayST[2 * j + 1]);
        }

        public void Modify(int index, int val)
        {
            if (index < 0 || index >= len) return;
            index = index + len; 
            arrayST[index] = val;

            for (int i = index >> 1; i >= 1; i >>= 1)
                arrayST[i] = this.rollUpCallBack(arrayST[i << 1], arrayST[i << 1 | 1]);
        }

        public int Query(int start, int end, int initResult)
        {
            int result = initResult;
            for (start += len, end += len; start <= end; start >>= 1, end >>= 1)
            {
                if (start % 2 == 1) result = this.rollUpCallBack(result, arrayST[start++]);
                if (end % 2 == 0) result = this.rollUpCallBack(result, arrayST[end--]);
            }
            return result;
        }
    }
}
