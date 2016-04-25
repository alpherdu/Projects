using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    public class InsertionSortClass
    {
        public static void Insertionsort(int[] A)
        {
            if (A == null) return;

            for (int i = 1; i < A.Length; i++)
            {
                int key = A[i];

                int j = i; // what should be at position j
                while (j > 0 && A[j-1] > key)
                {
                    A[j] = A[j-1];
                    j--;
                }
                A[j] = key;
            }
        }
    }
}
