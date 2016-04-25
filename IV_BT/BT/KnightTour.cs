using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    public class KnightTour
    {
        static int NOT_TOURED = -1;
        static int[] XMove = { 1, 1, -1, -1, 2, 2, -2, -2 };
        static int[] YMove = { 2, -2, 2, -2, 1, -1, 1, -1 };

        int boardSizeW;
        int boardSizeH;

        int[,] moveSequence;

        public KnightTour(int boardSizeW, int boardSizeH)
        {
            this.boardSizeW = boardSizeW;
            this.boardSizeH = boardSizeH;
            this.moveSequence = new int[boardSizeW, boardSizeH];

            for (int i = 0; i < boardSizeW; i++)
            {
                for (int j = 0; j < boardSizeH; j++)
                {
                    moveSequence[i, j] = NOT_TOURED;
                }
            }
        }

        public bool Solve(int initX, int initY)
        {
            int curMoveSequence = 0;
            moveSequence[initX, initY] = curMoveSequence;


            return solveUtil(initX, initY, curMoveSequence + 1);
        }

        bool solveUtil(int x, int y, int curMoveSequence)
        {
            if (curMoveSequence == boardSizeW * boardSizeH)
                return true;

            int nextX, nextY;
            for (int i = 0; i < XMove.Length; i++)
            {
                nextX = x + XMove[i];
                nextY = y + YMove[i];

                if (this.isSafe(nextX, nextY))
                {
                    moveSequence[nextX, nextY] = curMoveSequence;
                    if (solveUtil(nextX, nextY, curMoveSequence + 1))
                        return true;
                    else
                        moveSequence[nextX, nextY] = NOT_TOURED; //backtracking
                }
            }

            return false;
        }

        bool isSafe(int x, int y)
        {
            if (x < 0 || x >= this.boardSizeW) return false;
            if (y < 0 || y >= this.boardSizeH) return false;
            if (this.moveSequence[x, y] != NOT_TOURED) return false;

            return true;
        }

        public string PrintSolution()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < boardSizeW; i++)
            {
                for (int j = 0; j < boardSizeH; j++)
                {
                    sb.Append(moveSequence[i, j] + "," + "\t");
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
