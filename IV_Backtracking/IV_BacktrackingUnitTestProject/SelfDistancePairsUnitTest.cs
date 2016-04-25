using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class SelfDistancePairsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV_Backtracking.SelfDistancePairs sdp = new IV_Backtracking.SelfDistancePairs();

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 13; i++)
            {
                sb.AppendLine(i + ":" + sdp.SolveIt(i));
            }
        }
    }
}
