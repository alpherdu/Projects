using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
   //C(n, k) = C(n-1, k-1) + C(n-1, k)
   //C(n, 0) = C(n, n) = 1

    public static class BinomialCoefficient
    {

        public static int BinomialCoefficient_Topdown(int n, int k)
        {
            int[] bc = new int[n + 1];
            bc[0] = 1;  // nC0 is 1

            for (int i = 1; i <= n; i++)
            {
                // Compute next row of pascal triangle using
                // the previous row
                for (int j = Math.Min(i, k); j > 0; j--)
                    bc[j] = bc[j] + bc[j - 1];
            }
            return bc[k];
        }

        public static int BinomialCoefficient_DP(int n, int k)
        {
            int[] bc= new int[n+1];
            
            for(int iK = 0; iK <= k; iK++) //how many chose.
            {
                int preOld = 0;
                for (int jN = iK; jN < n+1; jN++)
                {
                    int cur = bc[jN];
                    if (iK == 0 || jN == iK)
                            bc[jN] = 1;
                    else
                        bc[jN] = bc[jN - 1] + preOld;

                    preOld = cur;
                }
            }
            return bc[n];
        }

        public static int BinomialCoefficient_Recursive(int n, int k)
        {
            if (n < k || n < 0) return 0;

            if (k == 0 || k == n) return 1;

            return BinomialCoefficient_Recursive(n - 1, k - 1) + BinomialCoefficient_Recursive(n - 1, k);

        }
    }
}
