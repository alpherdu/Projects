using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    public class RatInMaze
    {
        const int DEAD_END = 0;
        const int NOT_COVERD = 0;
        static readonly int[] XMove = { 0, 1 };
        static readonly int[] YMove = { 1, 0 };

        int mazeW { set; get; }
        int mazeH { set; get; }
        int[,] maze { set; get; }
        int[,] moveSequence;

        public RatInMaze(int[,] maze)
        {
            mazeW = maze.GetLength(0);
            mazeH = maze.GetLength(1);
            this.maze = maze;

            this.moveSequence = new int[this.mazeW, this.mazeH];
            for (int i = 0; i < this.mazeW; i++)
            {
                for (int j = 0; j < this.mazeH; j++)
                {
                    moveSequence[i, j] = NOT_COVERD;
                }
            }
        }

        public bool SolveIt(int initX, int initY)
        {
            int curMoveSequence = 1;
            moveSequence[initX, initY] = curMoveSequence;

            return SolveUtil(initX, initY, curMoveSequence + 1);
        }

        bool SolveUtil(int x, int y, int curMoveSequence)
        {
            if (x == this.mazeW - 1 && y == this.mazeH - 1)
                return true;

            int nextX, nextY;
            for (int i = 0; i < XMove.Length; i++)
            {
                nextX = x + XMove[i];
                nextY = y + YMove[i];

                if (IsSafe(nextX, nextY))
                {
                    moveSequence[nextX, nextY] = curMoveSequence;
                    if (SolveUtil(nextX, nextY, curMoveSequence + 1))
                        return true;
                    else
                        moveSequence[nextX, nextY] = NOT_COVERD; //backtracking
                }
            }

            return false;
        }

        bool IsSafe(int x, int y)
        {
            if (x < 0 || x >= mazeW) return false;
            if (y < 0 || y >= mazeH) return false;
            if (maze[x, y] == DEAD_END) return false;

            //no need for only move down or right;
            if (moveSequence[x, y] != NOT_COVERD) return false;

            return true;
        }

        public string PrintSolution()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.mazeW; i++)
            {
                for (int j = 0; j < this.mazeH; j++)
                {
                    sb.Append(moveSequence[i, j] + "," + "\t");
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }

    }
}
