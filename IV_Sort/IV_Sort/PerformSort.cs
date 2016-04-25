using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    public class PerformSort
    {
        public delegate void Sort(int[] A);

        public static void PerfromSort(Sort sortCallBack, int arraySize, bool radmonArraySize)
        {
            Random rdm = new Random();
            int len = radmonArraySize ? rdm.Next(arraySize) : arraySize;
            int[] A = new int[len];
            int[] B = new int[len];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rdm.Next(len);
                B[i] = A[i];
            }

            sortCallBack(A);
            Array.Sort(B);

            for (int i = 0; i < A.Length; i++)
                if (A[i] != B[i]) throw new Exception(string.Format("i:{0}, A[{0}]={1}, Expectig {2}", i, A[i], B[i]));
        }
    }
}
