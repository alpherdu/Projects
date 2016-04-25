using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_BST
{
    class Program
    {
        LinkedList<int> linklist = new LinkedList<int>();
        static void Main(string[] args)
        {
            int i = int.MinValue;
            i = -i;

            hstring[] x = {"(((())))","((()()))","((())())","((()))()","(()(()))","(()()())","(()())()","(())()()","()((()))","()(()())","()(())()","()(())()","()()(())","()()()()"};

            Array.Sort(x);


            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            Program p = new Program();
            p.CountNodes(root);

        }

        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;

            int nodeCount = 0;

            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);

            while (s.Count != 0)
            {
                nodeCount++;
                TreeNode node = s.Pop();

                if (node.right != null) s.Push(node.right);
                else if (node.left != null) s.Push(node.left);
            }

            return nodeCount;

            //when pop q.Count == qSizeMax)leafNodeCount++;  q.Count == 0 || q.Count == qSizeMax - 2) calculte;
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            int nodesFound = 0;
            int indexLCA = 0;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            TreeNode curNode;
            while (stack.Count != 0)
            {
                curNode = stack.Peek();
                if (curNode == p || curNode == q)
                {
                    nodesFound++;
                    if (nodesFound == 1)
                        indexLCA = stack.Count - 1;
                    else if (nodesFound == 2)
                    {
                        while (stack.Count - 1 != indexLCA) stack.Pop();

                        return stack.Pop();
                    }
                }
                if (curNode.right != null)
                    PushAllLeft(stack, curNode.right);
                else
                    stack.Pop();
            }

            return null;
        }

        void PushAllLeft(Stack<TreeNode> stack, TreeNode root)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
        }


    }
}
 