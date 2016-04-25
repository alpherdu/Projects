using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonClass;
using EPI2015;
using System.Collections.Generic;

namespace EPI2015UnitTest
{
    [TestClass]
    public class BinaryTree_10_12UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] A = { "H", "B", "F", "null", "null", "E", "A", "null", "null", "null", "C", "null", "D", "null", "G", "I", "null", "null", "null" };
            int[] B = { 1, 2, 3, int.MinValue, int.MinValue, 4, 5, int.MinValue, int.MinValue, int.MinValue, 6, int.MinValue, 7, int.MinValue, 8, 9, int.MinValue, int.MinValue, int.MinValue };

            TreeNode root = BinaryTrees_10_11.BuildTreeWithMark(B);
            SLLNode x = new BinaryTree_10_12().BuildSLLFromLeaves(root);

        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] A = { "H", "B", "F", "null", "null", "E", "A", "null", "null", "null", "C", "null", "D", "null", "G", "I", "null", "null", "null" };
            int[] B = { 1, 2, 3, int.MinValue, int.MinValue, 4, 5, int.MinValue, int.MinValue, int.MinValue, 6, int.MinValue, 7, int.MinValue, 8, 9, int.MinValue, int.MinValue, int.MinValue };

            TreeNode root = BinaryTrees_10_11.BuildTreeWithMark(B);
            List<TreeNode> x = new BinaryTree_10_12().BuildSLLFromLeaves_V1(root);

        }
    }
}
