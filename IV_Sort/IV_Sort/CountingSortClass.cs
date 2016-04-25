using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Sort
{
    public static class CountingSortClass
    {
        public static void CountingSort(int[] key)
        {
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] > max) max = key[i];
                if (key[i] < min) min = key[i];
            }
            max -= min;
            for (int i = 0; i < key.Length; i++) key[i] -= min;

            int[] countB = new int[max + 1];
            for (int i = 0; i < key.Length; i++) countB[key[i]]++;

            countB[0]--; //index of last element  
            for (int i = 1; i < countB.Length; i++) countB[i] += countB[i - 1];

            int[] outputC = new int[key.Length];
            for (int j = key.Length - 1; j >= 0; j--) // backwords so it is stable
            {
                outputC[countB[key[j]]] = key[j] + min;
                countB[key[j]]--;
            }

            for (int i = 0; i < key.Length; i++) key[i] = outputC[i];
        }
    }
}
