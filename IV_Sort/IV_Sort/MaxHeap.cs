using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    public class MaxHeap
    {
        private int[] A;
        private int maxIndex;

        public void BuildHeap(int[] array)
        {
            this.A = new int[array.Length + 1]; // [1...capacit], [0] is not used;

            this.maxIndex = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                A[i + 1] = array[i];
            }

            for (int j = array.Length >> 1; j >= 1; j--)
            {
                MaxHeapify(j);
            }
        }

        public void MaxHeapify(int i)
        {
            int lChild = LeftIndex(i);
            int rChild = RightIndex(i);
            int indexOfMax = i;

            if (HasLeftChild(i) && A[lChild] > A[i]) indexOfMax = lChild;

            if (hassRightChild(i) && A[rChild] > A[indexOfMax]) indexOfMax = rChild;// bug: use A[i] instead of maxIndex

            if (indexOfMax != i)
            {
                swap(ref A[i], ref A[indexOfMax]);
                MaxHeapify(indexOfMax);
            }
        }

        public void HeapSort()
        {
            int saveSize = this.maxIndex;
            for (int j = maxIndex; j >= 2; j--) // bug: 1
            {
                swap(ref A[1], ref A[j]);
                maxIndex--;
                MaxHeapify(1);
            }

            this.maxIndex = saveSize;
        }

        int Parent(int i)
        {
            return i >> 1;
        }

        int LeftIndex(int i)
        {
            return i << 1;
        }

        int RightIndex(int i)
        {
            return i << 1 | 1;
        }

        bool HasLeftChild(int i)
        {
            return LeftIndex(i) <= maxIndex;
        }

        bool hassRightChild(int i)
        {
            return RightIndex(i) <= maxIndex;
        }

        void swap(ref int i, ref int j)
        {
            if (i != j)
            {
                i ^= j;
                j ^= i;
                i ^= j;
            }
        }

        public int[] GetArray()
        {
            int[] resultArray = new int[this.maxIndex];
            Array.Copy(this.A, 1, resultArray, 0, this.maxIndex);

            return resultArray;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= this.maxIndex; i++) sb.Append(this.A[i] + ",");

            return sb.ToString();
        }
    }
}
