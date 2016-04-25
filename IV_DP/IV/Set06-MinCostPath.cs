using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV
{
    public static class MinCostPath
    {
        //Given a cost matrix cost[][] and a position (m, n) in cost[][], 
        //write a function that returns cost of minimum cost path to reach (m, n) from (0, 0). 
        //Each cell of the matrix represents a cost to traverse through that cell. 
        //Total cost of a path to reach (m, n) is sum of all the costs on that path 
        //(including both source and destination). You can only traverse down, 
        //right and diagonally lower cells from a given cell, i.e., 
        //from a given cell (i, j), cells (i+1, j), (i, j+1) and (i+1, j+1) can be traversed. 
        //You may assume that all costs are positive integers
        public static int MinCostPath_DP(int[,] cost, int m, int n)
        {
            int[,] travelCost = new int[m, n];

            travelCost[0, 0] = cost[0, 0];
            for (int col = 1; col < m; col++)
            {
                travelCost[col, 0] = cost[col, 0] + travelCost[col - 1, 0];
            }

            for (int row = 1; row < n; row++)
            {
                travelCost[0, row] = cost[0, row] + travelCost[0, row - 1];
            }

            for (int row = 1; row < n; row++)
            {
                for (int col = 1; col < m; col++)
                {
                    travelCost[col, row] = cost[col, row] +
                        Math.Min
                        (
                            Math.Min(travelCost[col, row - 1], travelCost[col - 1, row - 1]),
                            travelCost[col - 1, row]
                        );
                }
            }

            return travelCost[m-1, n-1];
        }
    }
}
