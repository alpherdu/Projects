using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    public class QuickerSortClass
    {
        public static void QuickSort(int[] A)
        {
            LomutoQuickSort(A, 0, A.Length - 1);

            //HoareQuickSort(A, 0, A.Length - 1);
        }

        public static void LomutoQuickSort(int[] A, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = LomutoPartition(A, lo, hi);
                LomutoQuickSort(A, lo, p - 1);
                LomutoQuickSort(A, p + 1, hi);
            }

        }

        // ...<= x......x > x ......unrestricted......x
        public static int LomutoPartition(int[] A, int lo, int hi)
        {
            //My Version
            int pivot = A[hi];
            int swapIndex = lo;
            for (int i = lo; i <= hi; i++)
            {
                if (A[i] <= pivot)
                {
                    swap(ref A[swapIndex], ref A[i]);
                    swapIndex++;
                }
            }
            return swapIndex - 1;
        }

        public static int LomutoPartition_book(int[] A, int lo, int hi)
        {
            int pivot = A[hi];

            int i = lo;
            for (int j = lo; j < hi; j++) // bug: j < hi -1
            {
                if (A[j] <= pivot)
                {
                    swap(ref A[i], ref A[j]);
                    i++;
                }
            }
            swap(ref A[i], ref A[hi]);

            return i;
        }

        public static void HoareQuickSort(int[] A, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = LomutoPartition(A, lo, hi);
                HoareQuickSort(A, lo, p - 1);
                HoareQuickSort(A, p + 1, hi);
            }

        }
        public static int HoarePartition(int[] A, int lo, int hi)
        {
            int x = A[lo];

            lo--;
            hi++;
            for (;;)
            {
                do { hi--; } while (A[hi] >= x);
                do { lo++; } while (A[lo] <= x);
                if (lo < hi)
                    swap(ref A[lo], ref A[hi]);
                else
                    return hi;
            }

        }

        static void swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }

    }
}
