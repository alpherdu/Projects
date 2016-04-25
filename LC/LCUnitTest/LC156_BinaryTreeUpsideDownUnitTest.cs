using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonClass;

namespace LCUnitTest
{
    [TestClass]
    public class LC156_BinaryTreeUpsideDownUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            var x = LC.LC156_BinaryTreeUpsideDown.UpsideDownBinaryTree(root);
        }
        [TestMethod]
        public void TestMethod2()
        {
             var x = LC.LC156_BinaryTreeUpsideDown.UpsideDownBinaryTree(null);
        }

        [TestMethod]
        public void TestMethod3()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);

            var x = LC.LC156_BinaryTreeUpsideDown.UpsideDownBinaryTree(root);
        }
    }
}
