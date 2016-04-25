using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClass;

namespace EPI2015
{
    public class BinaryTrees_10_11
    {
        public static TreeNode BuildTreeWithMark(int[] B)
        {
            int consumed = 0;
            TreeNode root = BuildTree(B, 0, ref consumed);
            return root;
        }

        static TreeNode BuildTree(int[] B, int start, ref int consumed)
        {
            //consumed = 0;
            //if (A == null || A.Length == 0 ) return null;
            consumed = 1;
            if (B[start] == int.MinValue) return null; 

            TreeNode root = new TreeNode(B[start]);

            int leftConsumed = 0;
            root.left = BuildTree(B, start + 1, ref leftConsumed);
            int rightConsumed = 0;
            root.right = BuildTree(B, start + 1 + leftConsumed, ref rightConsumed);

            consumed = 1 + leftConsumed + rightConsumed;
            return root;
        }
    }
}
