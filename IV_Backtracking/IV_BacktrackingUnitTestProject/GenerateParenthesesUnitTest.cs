using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IV_BacktrackingUnitTestProject
{
    [TestClass]
    public class GenerateParenthesesUnitTest
    {
        [TestMethod]
        public void TestMethod0()
        {
            IV_Backtracking.GenerateParentheses gp = new IV_Backtracking.GenerateParentheses();
            var x = gp.SolveIt(0);
        }

        [TestMethod]
        public void TestMethod1()
        {
            IV_Backtracking.GenerateParentheses gp = new IV_Backtracking.GenerateParentheses();
            var x = gp.SolveIt(1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IV_Backtracking.GenerateParentheses gp = new IV_Backtracking.GenerateParentheses();
            var x = gp.SolveIt(2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            IV_Backtracking.GenerateParentheses gp = new IV_Backtracking.GenerateParentheses();
            var x = gp.SolveIt(3);
        }

        [TestMethod]
        public void TestMethod10()
        {
            IV_Backtracking.GenerateParentheses gp = new IV_Backtracking.GenerateParentheses();
            var x = gp.SolveIt(10);
        }
    }
}
