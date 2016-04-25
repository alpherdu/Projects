using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IV_BST;
using System.Collections.Generic;

namespace BSTUnitTestProject
{
    [TestClass]
    public class BSTUnitTest
    {
        [TestMethod]
        public void InsertTestMethod()
        {
            /* Let us create following BST
                      50
                   /     \
                  30      70
                 /  \    /  \
               20   40  60   80 */

            int[] array = { 50, 30, 20, 40, 70, 60, 80 }; //, 58,57,59 };
            int[] resultArray;

            TreeNode root = BST.Insert(null, array);
            resultArray = BST.InorderTraversalAsArray(root);

            BST.Delete(root, 20);
            resultArray = BST.InorderTraversalAsArray(root);

            BST.Delete(root, 30);
            resultArray = BST.InorderTraversalAsArray(root);

            BST.Delete(root, 70);
            resultArray = BST.InorderTraversalAsArray(root);

            BST.Delete(root, 50);
            resultArray = BST.InorderTraversalAsArray(root);

            BST.Delete(root, 60);
            resultArray = BST.InorderTraversalAsArray(root);

        }

        [TestMethod]
        public void InorderTraversal_Iterative_TestMethod()
        {
            /* Let us create following BST
                      50
                   /     \
                  30      70
                 /  \    /  \
               20   40  60   80 */

            int[] array = { 50, 30, 20, 40, 70, 60, 80 }; //, 58,57,59 };


            TreeNode root = BST.Insert(null, array);
            var x = BST.InorderTraversal_Iterative(root);

            int[] resultArray = ((List<int>)x).ToArray();
        }

        [TestMethod]
        public void IsBST_Iterative_TestMethod()
        {
            /* Let us create following BST
                      50
                   /     \
                  30      70
                 /  \    /  \
               20   40  60   80 */

            int[] array = { 50, 30, 20, 40, 70, 60, 80 }; //, 58,57,59 };


            TreeNode root = BST.Insert(null, array);
            var x = BST.IsBST_Iterative(root);

        }
    }
}
