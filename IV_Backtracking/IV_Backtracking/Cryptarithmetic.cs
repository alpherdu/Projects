using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    public class Cryptarithmetic
    {
        private string[] puzzle;
        private Dictionary<char, int> mapping = new Dictionary<char, int>();
        private char[] letterSetArray;
        private List<KeyValuePair<char, int>[]> results = new List<KeyValuePair<char, int>[]>();

        public Cryptarithmetic(string[] puzzle)
        {
            this.puzzle = puzzle;
            foreach (string word in puzzle)
            {
                foreach (char letter in word)
                {
                    if (!mapping.ContainsKey(letter)) mapping.Add(letter, -1);
                }
            }

            this.letterSetArray = mapping.Keys.ToArray();
        }

        public bool SolveIt()
        {
            if (letterSetArray.Length > 10) return false;

            SolveItUtil(0);

            return this.results.Count != 0;
        }

        private void SolveItUtil(int curPos)
        {
            if (curPos == this.letterSetArray.Length)
                CheckSolution();
            else
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (IsSafe(i, curPos))
                    {
                        mapping[letterSetArray[curPos]] = i;
                        SolveItUtil(curPos + 1);
                        mapping[letterSetArray[curPos]] = -1;
                    }
                }
            }
        }

        private bool IsSafe(int number, int curPos)
        {
            for (int i = 0; i < puzzle.Length; i++)
                if (number == 0 && letterSetArray[curPos] == puzzle[i][0]) return false;

            return !mapping.Values.Contains(number);
        }

        private bool CheckSolution()
        {
            int x = letterToNum(this.puzzle[0]);
            int y = letterToNum(this.puzzle[1]);
            int z = letterToNum(this.puzzle[2]);

            if (x + y == z)
                this.results.Add(mapping.ToArray());

            return x + y == z;
        }

        private int letterToNum(string str)
        {
            int x = 0;
            for (int i = 0; i < str.Length; i++)
                x = x * 10 + mapping[str[i]];

            return x;
        }
    }
}
