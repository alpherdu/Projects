using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_BinaryIndexedTree
{
    public class BinaryIndexedTree
    {
        int[] A;
        int size;
        public BinaryIndexedTree(int[] frequency)
        {
            this.size = frequency.Length + 1;
            this.A = new int[size];

            for (int i = 0; i < frequency.Length; i++)
            {
                this.Add(i, frequency[i]);
            }
        }

        public void Add(int i, int val) //i is 0- based
        {
            i++;

            while (i < size)
            {
                A[i] += val;
                i += i & -i;
            }
        }
        public int GetSum(int i) // is is 0-based
        {
            i++;

            int sum = 0;
            while (i > 0)
            {
                sum += A[i];
                i -= i & -i;
            }
            return sum;
        }
    }

}
