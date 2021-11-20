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
        internal void AddInReverseOrder(int data)
        {
            Node newnode = new Node(data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node InsertAtPostion(int postion , int data)
        {
            Node Newestnode = new Node(data);
            if (this.head == null)
            {
                return Newestnode;
            }
            if (postion == 0)
            {
                Newestnode.next = this.head;
                this.head = Newestnode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < postion)
            {
                prev = current;
                current = current.next;
                count++;
            }
            Newestnode.next = prev.next;
            prev.next = Newestnode;
            return this.head;
        }
    }
}
