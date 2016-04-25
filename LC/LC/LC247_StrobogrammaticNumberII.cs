using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC
{
    public static class LC247_StrobogrammaticNumberII
    {
        public static List<string> FindStrobogrammatic(int n)
        {
            const int HIGHTEST_DIGITt = 0, MIDDLE_DIGIT = 1, CENTRAL_DIGITt = 2;

            int[][][] options = new int[][][]{
                new int[][] { new int[]{ 1, 6, 8, 9 }, new int[]{ 0, 1, 6, 8, 9 }, new int[]{ 0, 1, 8 }},
                new int[][] { new int[]{ 1, 9, 8, 6 }, new int[]{ 0, 1, 9, 8, 6 }, new int[]{ 0, 1, 8 }}};

            List<string> listLeft = new List<string>();
            List<string> listRight = new List<string>();

            int lo = 0, hi = n - 1;

            listLeft.Add(string.Empty);
            listRight.Add(string.Empty);
            int endIndex = 0;

            while (lo <= hi)
            {
                int curOption;
                if (lo == hi) curOption = CENTRAL_DIGITt;
                else if (lo == 0) curOption = HIGHTEST_DIGITt;
                else curOption = curOption = MIDDLE_DIGIT;

                for (int i = 0; i <= endIndex; i++)
                {
                    for (int j = 0; j < options[0][curOption].Length; j++)
                    {
                        listLeft.Add(listLeft[i] + options[0][curOption][j]);

                        if (curOption == CENTRAL_DIGITt) listRight.Add("" + listRight[i]);
                        else listRight.Add(options[1][curOption][j] + listRight[i]);
                    }
                }

                listLeft.RemoveRange(0, endIndex + 1);
                listRight.RemoveRange(0, endIndex + 1);
                endIndex = listLeft.Count - 1;

                lo++;
                hi--;
            }

            for (int i = 0; i < listLeft.Count; i++) listLeft[i] += listRight[i];

            return listLeft;
        }
    }
}
