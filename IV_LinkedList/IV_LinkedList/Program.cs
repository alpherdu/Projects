using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IV_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

        }

        void DeleteNodeTest()
        {
            Node head = null;

            head = Node.AppendToTail(head, 3);
            head = Node.AppendToTail(head, 4);
            head = Node.InsertTohead(head, 2);
            head = Node.InsertTohead(head, 1);

            head = Node.DeleteNode(head, 4);
            head = Node.DeleteNode(head, 1);
            head = Node.DeleteNode(head, 3);
            head = Node.DeleteNode(head, 2);
            head = Node.DeleteNode(head, -1);
        }
    }
}
