using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClass;

namespace LC
{
    public static class LC156_BinaryTreeUpsideDown
    {
        public static TreeNode UpsideDownBinaryTree(TreeNode root)
        {
            if (root == null) return null;

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (root != null)
            {
                s.Push(root);
                root = root.left;
            }

            root = s.Pop();
            TreeNode cur = root;
            while (s.Count != 0)
            {
                cur.left = s.Peek().right;
                cur.right = s.Pop();
                cur = cur.right;
            }
            cur.left = null;
            cur.right = null;

            return root;
        }
    }
}
