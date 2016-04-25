using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    public class HeapSortClass
    {
        public static void HeapSort(int[] A)
        {
            MaxHeap maxHeap = new MaxHeap( );
            maxHeap.BuildHeap(A);
            maxHeap.HeapSort();
            int[] result = maxHeap.GetArray();
            Array.Copy(result, A, A.Length);
        }
    }
}
