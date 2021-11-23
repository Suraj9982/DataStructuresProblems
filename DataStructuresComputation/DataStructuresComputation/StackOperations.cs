using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresComputation
{
    internal class StackOperations
    {
        Node top;
        public StackOperations()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node newnode = new Node(data);
            if(top == null)
            {
                newnode.next = null;
            }
            else
            {
                newnode.next = top;
            }
            top = newnode;
            Console.WriteLine("{0} item pushed to stack ", newnode.data);
        }
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("stack is in undefllow condition");
                return;
            }
            Console.WriteLine("{0} item pooped out from stack", top.data);
            top = top.next;
        }
        internal void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("stack is in undefllow condition");
                return;
            }
            Console.WriteLine("{0},is on the top of the stack", this.top.data);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void PeekAndPop()
        {
            Peek();
            Pop();
        }
    }   
}
