using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class NQueenUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV_Backtracking.NQueen nQueen = new IV_Backtracking.NQueen(8);
            var x = nQueen.SolveIt();
        }
    }
}
