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
    }
    
}
