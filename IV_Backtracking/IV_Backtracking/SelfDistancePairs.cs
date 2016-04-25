using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Backtracking
{
    ///////////////////////////////////////////////////////////
    // improve: concise algorithm
    ///////////////////////////////////////////////////////////
    public class SelfDistancePairs
    {
        int N;
        private int[] assignments;
        HashSet<int> assingented;
        List<int[]> result = new List<int[]>();

        public int SolveIt(int N)
        {
            this.N = N;
            this.assignments = new int[N << 1];
            this.assingented = new HashSet<int>();
            this.result = new List<int[]>();

            SolveItUtil(0);

            return result.Count();
        }

        private void SolveItUtil(int curPos)
        {
            if (assingented.Count == this.N)
            {
                this.result.Add(this.assignments.ToArray());
                return;
            }

            while (curPos < this.N && assignments[curPos] != 0) curPos++;//bug: need to find next unassigned position

            if (curPos < assignments.Length)
            {
                for (int i = 1; i <= N; i++)
                {
                    int theOtherPos = -1;
                    if (IsSafe(curPos, i, ref theOtherPos))
                    {
                        this.assingented.Add(i);
                        this.assignments[curPos] = i;
                        this.assignments[theOtherPos] = i;

                        SolveItUtil(curPos + 1);

                        this.assingented.Remove(i);
                        this.assignments[curPos] = 0;
                        this.assignments[theOtherPos] = 0;
                    }
                }
            }
        }

        private bool IsSafe(int curPos, int number, ref int theOtherPos)
        {
            if (assingented.Contains(number) || assignments[curPos] != 0) return false;

            theOtherPos = curPos + number + 1;
            if (theOtherPos < this.N * 2 && assignments[theOtherPos] == 0) return true;

            return false;
        }
    }
}
