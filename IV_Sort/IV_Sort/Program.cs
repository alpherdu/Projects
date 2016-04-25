using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //int[] A = { 1, 12, 5, 26, 7, 14, 3, 7, 2 };

            //    //int[] A = { 7, 7, 5, 7, 14 };
            //    int[] A = { 2, 5, 3, 0, 2, 3, 0, 3 };
            //    IV_Sort.CountingSortClass.CountingSort(A);


            var x = CountBits(0);
        }


        static public int[] CountBits(int num)
        {
            if (num < 0) return new int[0];
            if (num == 0) return new int[] { 0 };

            int[] result = new int[num + 1];
            long blockSize = 1;
            while (true)
            {
                int i = 0;
                for (; i < blockSize; i++)
                {
                    result[i + blockSize] = 1 + result[i];
                    if (num == i + blockSize) return result;
                }
                blockSize <<= 1;
            }

        }
    }
}
