using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class EditDistance
    {
        public const int Insert_Weight = 1;
        public const int Delete_Weight = 1;
        public const int substitude_Weight = 1;
        public static int EditDistance_Recursive(string X, String Y, out string editOps)
        {
            int dist;
            editOps = string.Empty;
            if (String.IsNullOrEmpty(X) && String.IsNullOrEmpty(Y))
            {
                dist = 0;
            }
            else if (String.IsNullOrEmpty(X))
            {
                dist = Insert_Weight * Y.Length;
            }
            else if (String.IsNullOrEmpty(Y))
            {
                dist = Delete_Weight * X.Length;
            }
            else if (X[X.Length-1] == Y[Y.Length-1])
            {
                dist = EditDistance_Recursive(X.Substring(0, X.Length - 1), Y.Substring(0, Y.Length - 1), out editOps);
            }
            else
            {
                // min of ins, del and sub
                dist = Min(
                    EditDistance_Recursive(X.Substring(0, X.Length - 1), Y, out editOps) + Insert_Weight,
                    EditDistance_Recursive(X, Y.Substring(0, Y.Length -1),out editOps) + Delete_Weight,
                    EditDistance_Recursive(X.Substring(0, X.Length - 1), Y.Substring(0, Y.Length - 1), out editOps) + substitude_Weight
                    );
            }

            return dist;
        }

        public static int EditDistance_DP(string X, String Y, out string editOps)
        {
            editOps = string.Empty;

            if (String.IsNullOrEmpty(X) && String.IsNullOrEmpty(Y))
            {
                return 0;
            }
            else if (String.IsNullOrEmpty(X))
            {
                return Insert_Weight * Y.Length;
            }
            else if (String.IsNullOrEmpty(Y))
            {
                return Delete_Weight * X.Length;
            }

            int[,] editDist = new int[X.Length, Y.Length];
            
            for (int j = 0; j < Y.Length; j++)
            {
                editDist[0, j] = IV.EditDistance.Insert_Weight * (j + 1);
            }

            for (int i = 0; i < X.Length; i++)
            {
                editDist[i, 0] = IV.EditDistance.Delete_Weight * (i + 1);
            }

            for (int i = 1; i < X.Length; i++)
            {
                for (int j = 1; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                        editDist[i, j] = editDist[i - 1, j - 1];
                    else
                        editDist[i, j] = Min(
                            editDist[i - 1, j] + IV.EditDistance.Insert_Weight,
                            editDist[i, j - 1] + IV.EditDistance.Delete_Weight,
                            editDist[i-1, j-1]+IV.EditDistance.substitude_Weight
                            );
                }
            }

            return editDist[X.Length - 1, Y.Length - 1];
        }
            static int Min(int x, int y, int z)
        {
            if (x < y && x < z) return x;

            if (y < x && y < z) return y;

            return z;
        }
    }
}
