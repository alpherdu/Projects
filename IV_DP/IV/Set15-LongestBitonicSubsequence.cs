using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public class Set15_LongestBitonicSubsequence
    {
        public int GetLBS(int[] A)
        {
            if (A == null || A.Length == 0) return 0;

            int N = A.Length;

            int[] lis = new int[N];
            for (int i = 0; i < N; i++)
            {
                lis[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (A[j] < A[i] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;
                }
            }

            int[] lds = new int[N];
            for (int i = N - 1; i >= 0; i--)
            {
                lds[i] = 1;
                for (int j = N - 1; j > i; j--)
                {
                    if (A[j] < A[i] && lds[i] < lds[j] + 1)
                        lds[i] = lds[j] + 1;
                }
            }

            int lbs = 1;
            for (int i = 0; i < N; i++)
            {
                var bitonicSeq = lis[i] + lds[i] - 1;
                if (lbs < bitonicSeq) lbs = bitonicSeq;
            }

            return lbs;
        }
    }
}
