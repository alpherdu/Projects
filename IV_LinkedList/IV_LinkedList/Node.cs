using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_LinkedList
{
    public class Node
    {
        int Val { set; get; }
        public Node Next { set; get; }

        public Node(int val)
        {
            this.Val = val;
        }

        public static Node AppendToTail(Node head, int val)
        {
            Node tNode = new Node(val);

            if (head == null) return tNode;

            while (head.Next != null)
            {
                head = head.Next;
            }
            head.Next = tNode;

            return head;
        }

        public static Node InsertTohead(Node head, int val)
        {
            Node tNode = new Node(val);
            tNode.Next = head;

            return tNode;
        }

        public static Node DeleteNode(Node head, int val)
        {
            if (head == null) return null;

            if (head.Val == val) return head.Next;

            Node pre = head;
            while (pre.Next != null )
            {
                if(pre.Next.Val == val)
                {
                    pre.Next = pre.Next.Next;
                    break;
                }

                pre = pre.Next;
            }

            return head;
        }
    }
}
