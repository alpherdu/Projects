using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_BST
{
    public static class BST
    {
        public static TreeNode Search(TreeNode root, int key)
        {
            if (root == null || root.val == key)
                return root;
            else if (key < root.val)
                return Search(root.left, key);
            else
                return Search(root.right, key);
        }

        public static TreeNode Insert(TreeNode root, int key)
        {
            if (root == null)
                return new TreeNode(key);
            else if (key < root.val)
                root.left = Insert(root.left, key);
            else
                root.right = Insert(root.right, key);

            return root;
        }

        public static TreeNode Insert(TreeNode root, int[] array)
        {
            if (array == null || array.Length == 0) return root;

            for (int i = 0; i < array.Length; i++)
            {
                root = Insert(root, array[i]);
            }

            return root;
        }

        public static IList<int> InorderTraversal_Recursive(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;

            list.AddRange(InorderTraversal_Recursive(root.left));
            list.Add(root.val);
            list.AddRange(InorderTraversal_Recursive(root.right));

            return list;
        }

        public static IList<int> InorderTraversal_Iterative(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;

            Stack<TreeNode> s = new Stack<TreeNode>();
            PushLeftAll(s, root);

            while (s.Count != 0)
            {
                TreeNode aNode = s.Pop();
                list.Add(aNode.val);
                PushLeftAll(s, aNode.right);
            }

            return list;
        }
        
        static void PushLeftAll(Stack<TreeNode> s, TreeNode root)
        {
            if (s == null) return;

            while (root != null)
            {
                s.Push(root);
                root = root.left;
            }
        }

        public static bool IsBST_Iterative(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> s = new Stack<TreeNode>();
            PushLeftAll(s, root);

            int previousVal = int.MinValue;
            while (s.Count != 0)
            {
                TreeNode aNode = s.Pop();

                if (aNode.val < previousVal) return false;
                previousVal = aNode.val;

                PushLeftAll(s, aNode.right);
            }

            return true;
        }

        //wrong
        public static IList<int> DFS_LevelOrderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            if (root == null) return list;

            list.AddRange(InorderTraversal_Recursive(root.left));
            list.Add(root.val);
            list.AddRange(InorderTraversal_Recursive(root.right));

            return list;
        }

        public static int[] InorderTraversalAsArray(TreeNode root)
        {
            return InorderTraversal_Recursive(root).ToArray();
        }

        public static TreeNode Delete(TreeNode root, int key)
        {
            if (root == null) return null;

            if (key < root.val)
                root.left = Delete(root.left, key);
            else if (key > root.val)
                root.right = Delete(root.right, key);

            // key == root.val 
            else
            {
                if (root.left == null)
                    root = root.right;
                else if (root.right == null)
                    root = root.left;
                else // both children nodes are not null
                {
                    int nextBiggerKey = BST.MinValue(root.right);
                    root.val = nextBiggerKey;
                    root.right = Delete(root.right, nextBiggerKey);
                }
            }

            return root;
        }

        public static int MinValue(TreeNode root)
        {
            if (root == null) throw new ArgumentException();

            TreeNode aNode = root;

            while (aNode.right != null) aNode = aNode.right;

            return aNode.val;
        }

        public static int MaxValue(TreeNode root)
        {
            if (root == null) throw new ArgumentException();

            TreeNode aNode = root;

            while (aNode.left != null) aNode = aNode.left;

            return aNode.val;
        }

        
    }
}
