using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class Permutation
    {
        List<string> result = new List<string>();

        public List<string> SolveIt(string input)
        {
            char[] array = input.ToArray();
            Array.Sort(array); // sorting is for distinct permuation

            SolveItUtil(array, 0);

            return result;
        }

        private void SolveItUtil(char[] input, int left)
        {
            if (left == input.Length - 1)
                result.Add(new string(input));
            else
            {
                //SolveItUtil(input, left + 1, right);
                for (int i = left; i <= input.Length - 1 ; i++)
                {
                    if (i != left && input[i] == input[i-1]) continue; // for distinct permutation

                    swap(input, left, i);
                    SolveItUtil(input, left + 1);
                    swap(input, left, i);
                }
            }
        }

        private void swap(char[] input, int i, int j)
        {
            char temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
