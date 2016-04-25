using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    public class MergeSortClass
    {
        public static void MergeSort(int[] A)
        {
            MergeSort(A, 0, A.Length - 1);//bug: A.Length
        }

        static void MergeSort(int[] A, int start, int end)
        {
            if (start == end) return; //bug: end - start <= 1

            int mid = start + (end - start) / 2;
            MergeSort(A, start, mid);
            MergeSort(A, mid + 1, end);
            Merge(A, start, mid, end);
        }

        static void Merge(int[] A, int start, int mid, int end)
        {
            int[] B = new int[mid - start + 1]; //[start, mid]
            int[] C = new int[end - mid];//[mid+1, end]

            for (int i = 0; i < B.Length; i++)
                B[i] = A[start + i];

            for (int i = 0; i < C.Length; i++)
                C[i] = A[mid + 1 + i];

            int iA = start, iB = 0, iC = 0;
            while (iB < B.Length && iC < C.Length)
            {
                if (B[iB] < C[iC])
                    A[iA++] = B[iB++];
                else
                    A[iA++] = C[iC++];
            }

            while (iB < B.Length) A[iA++] = B[iB++];
            while (iC < C.Length) A[iA++] = C[iC++];
        }
    }
}
