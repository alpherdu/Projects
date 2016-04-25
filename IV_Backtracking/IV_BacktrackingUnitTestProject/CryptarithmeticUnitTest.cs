using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class CryptarithmeticUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] puzzle = { "SEND", "MORE", "MONEY" };
            IV_Backtracking.Cryptarithmetic crypt = new IV_Backtracking.Cryptarithmetic(puzzle);

            var x = crypt.SolveIt();
        }
    }
}
