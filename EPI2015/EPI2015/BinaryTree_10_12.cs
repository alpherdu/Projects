using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClass;

namespace EPI2015
{
    public class BinaryTree_10_12
    {
        public SLLNode BuildSLLFromLeaves(TreeNode root)
        {
            SLLNode fakeH = new SLLNode(-1);
            SLLNode tail = fakeH;
            BuildSLLFromLeavesUtil(root, ref tail);
            return fakeH.next;
        }
        void BuildSLLFromLeavesUtil(TreeNode root, ref SLLNode tail)
        {
            if (root == null) return;
            if(root.left == null && root.right == null)
            {
                tail.next = new SLLNode(root.val);
                tail = tail.next;
            }

            BuildSLLFromLeavesUtil(root.left, ref tail);
            BuildSLLFromLeavesUtil(root.right, ref tail);
        }

        public List<TreeNode> BuildSLLFromLeaves_V1(TreeNode root)
        {
            List<TreeNode> list = new List<TreeNode>();
            BuildSLLFromLeavesUtil_V1(root, list);
            return list;
        }
        void BuildSLLFromLeavesUtil_V1(TreeNode root, List<TreeNode> list)
        {
            if (root == null) return;
            if (root.left == null && root.right == null) list.Add(root);

            BuildSLLFromLeavesUtil_V1(root.left, list);
            BuildSLLFromLeavesUtil_V1(root.right, list);
        }
    }
}
