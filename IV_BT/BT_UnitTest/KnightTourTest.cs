using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BT_UnitTest
{
    [TestClass]
    public class KnightTourTest
    {
        [TestMethod]
        public void KnightTourTestMethod()
        {
            BT.KnightTour knightTour = new BT.KnightTour(5, 5);
            if (knightTour.Solve(0, 0))
            {
               string solution = knightTour.PrintSolution();
            }
        }
    }
}
