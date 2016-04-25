using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EPI2015;

namespace EPI2015UnitTest
{
    [TestClass]
    public class BinaryTrees_10_11UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] A = { "H", "B", "F", "null", "null", "E", "A", "null", "null", "null", "C", "null", "D", "null", "G", "I", "null", "null", "null" };
            int[] B = { 1, 2, 3, int.MinValue, int.MinValue, 4, 5, int.MinValue, int.MinValue, int.MinValue, 6, int.MinValue, 7, int.MinValue, 8, 9, int.MinValue, int.MinValue, int.MinValue };

            CommonClass.TreeNode root = BinaryTrees_10_11.BuildTreeWithMark(B);

        }
    }
}
