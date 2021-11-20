using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresComputation
{
   public class LinkedList
    {
        internal Node head;
        public void Adddata(int data)
        {
            Node node = new Node(data);
             if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted items in linkedlist", node.data);
        }
    }
}
