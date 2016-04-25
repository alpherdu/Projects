using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class PermutationUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IV_Backtracking.Permutation perm = new IV_Backtracking.Permutation();
            var x = perm.SolveIt("9100");
        }
    }
}
