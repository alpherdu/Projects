using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    public class NQueenProblem
    {
        const int AVAILABLE_CELL = 0;
        readonly int boardSize;
        int[,] board;// 0: available; x>0: occupied by queen x; x<0: attacked by queen |x|;

        IList<string> solutions = new List<string>();

        public NQueenProblem(int boardSize)
        {
            this.boardSize = boardSize;

            this.board = new int[this.boardSize, this.boardSize];
            this.restoreBaord();
        }

        public bool SolveIt()
        {
            int curQueen = 1;
            bool foundSolution = false;

            //only start with top-left quarter
            for (int i = 0; i < (boardSize + 1) / 2; i++)
            {
                for (int j = 0; j < (boardSize + 1) / 2; j++)
                {
                    foundSolution |= SolveUtil(i, j, curQueen);
                }
            }

            return foundSolution;

        }

        private bool SolveUtil(int initX, int initY, int curQueen)
        {
            if (!PlaceAQueen(initX, initY, curQueen))
                return false;

            if (curQueen == this.boardSize)
            {
                string aSolution = this.ComplileASolution();
                if (!this.solutions.Contains(aSolution)) this.solutions.Add(aSolution);

                BacktrackingAQueen(curQueen);
                return true;
            }

            bool solved = false;
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (board[i, j] == AVAILABLE_CELL)
                    {
                        solved |= SolveUtil(i, j, curQueen + 1);
                    }
                }
            }

            BacktrackingAQueen(curQueen);
            return solved;

        }

        bool PlaceAQueen(int x, int y, int queen)
        {
            if (board[x, y] != AVAILABLE_CELL)
                return false;

            board[x, y] = queen;

            for (int i = 0; i < this.boardSize; i++)
            {
                for (int j = 0; j < this.boardSize; j++)
                {
                    if (board[i, j] != AVAILABLE_CELL) continue;
                    else if (i == x || j == y || Math.Abs(i - x) == Math.Abs(j - y))
                        board[i, j] = -queen;
                }
            }

            return true;
        }

        void BacktrackingAQueen(int queen)
        {
            for (int i = 0; i < this.boardSize; i++)
            {
                for (int j = 0; j < this.boardSize; j++)
                {
                    if (board[i, j] == -queen || board[i, j] == queen) board[i, j] = AVAILABLE_CELL;
                }
            }
        }

        public int GetSolutionsCount()
        {
            return this.solutions.Count;
        }

        public string PrintSolution()
        {
            solutions = this.solutions.Distinct().ToList();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.solutions.Count; i++)
            {
                sb.Append(solutions[i] + "\n");
            }

            return sb.ToString();
        }

        public IList<IList<string>> PrintSolutionAsList()
        {
            solutions = this.solutions.Distinct().ToList();

            IList<IList<string>> list = new List<IList<string>>();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.solutions.Count; i++)
            {
                List<string> subList = new List<string>();
                string s = solutions[i];
                s = s.Replace(",", "");
                s = s.Replace("\t", "");
                s = s.Replace('1', 'Q').Replace('0', '.');
                s = s.Substring(0, s.Length - 1);

                foreach (string row in s.Split('\n')) subList.Add(row);
                list.Add(subList);
            }

            return list;
        }

        public string ComplileASolution()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.boardSize; i++)
            {
                for (int j = 0; j < this.boardSize; j++)
                {
                    int x = board[i, j] > 0 ? 1 : 0;
                    sb.Append(x + "," + "\t");
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }

        private void restoreBaord()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = AVAILABLE_CELL;
                }
            }
        }
    }
}
