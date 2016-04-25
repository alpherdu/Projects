using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class LCS
    {
        public static int LCS_Recursive(string X, string Y)
        {
            if (String.IsNullOrEmpty(X) || String.IsNullOrEmpty(Y))
                return 0;
            if (X[X.Length - 1] == Y[Y.Length - 1])
                return 1 + LCS_Recursive(X.Substring(0, X.Length - 1), Y.Substring(0, Y.Length - 1));
            else
                return Math.Max
                    (
                    LCS_Recursive(X, Y.Substring(0, Y.Length - 1)),
                    LCS_Recursive(X.Substring(0, X.Length - 1), Y)
                    );
        }

        public static int LCS_DP(string X, string Y, out string LCSResult)
        {
            LCSResult = string.Empty;
            if (String.IsNullOrEmpty(X) || String.IsNullOrEmpty(Y))
            {
                return 0;
            }

            int[,] LCS = new int[X.Length + 1, Y.Length + 1];
            //default value of int[,] is set to 0, so, no need to init LCS[0,] and LCS[,0]

            //trick, the first element is at index = 1
            for (int i = 1; i < X.Length + 1; i++)
            {
                for (int j = 1; j < Y.Length + 1; j++)
                {
                    if (X[i - 1] == Y[j - 1])//index to access String
                        LCS[i, j] = 1 + LCS[i - 1, j - 1];
                    else
                        LCS[i, j] = Math.Max(LCS[i, j - 1], LCS[i - 1, j]);
                }

            }

            LCSResult = LCS.ConstructLCS(X, Y);

            return LCS[X.Length, Y.Length];
        }

        public static string ConstructLCS(this int[,] data, string X, string Y)
        {
            StringBuilder sb = new StringBuilder();

            int i = X.Length;
            int j = Y.Length;

            while (i > 0 && j > 0)
            {
                if (X[i-1] == Y[j-1])
                {
                    sb.Insert(0, X[i-1]);
                    i--;
                    j--;
                }
                else
                {
                    if (data[i, j] == data[i - 1, j]) i--;
                    else if (data[i, j] == data[i, j - 1]) j--;
                }
            }

            return sb.ToString();
        }



    }
}
