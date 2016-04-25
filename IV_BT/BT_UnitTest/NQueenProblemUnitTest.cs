using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BT_UnitTest
{
    [TestClass]
    public class NQueenProblemUnitTest
    {
        [TestMethod]
        public void NQueenProblemTestMethod()
        {
            //number of possible solutions
            //http://www.durangobill.com/N_Queens.html

            string solutins;
            int solutionsCount;
            for (int boardSize = 4; boardSize <= 12; boardSize++)
            {
                solutins = null;
                solutionsCount = 0;

                BT.NQueenProblem nQueenProblem = new BT.NQueenProblem(boardSize);
                if (nQueenProblem.SolveIt())
                {
                    solutins = nQueenProblem.PrintSolution();
                    solutionsCount = nQueenProblem.GetSolutionsCount();

                    var x = nQueenProblem.PrintSolutionAsList();
                }
            }
        }
    }
}
