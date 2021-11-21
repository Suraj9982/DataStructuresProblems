using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresComputation
{
    class QueueOperation
    {
        Node front;
        Node rear;
        public QueueOperation()
        {
            this.front = this.rear = null;
        }
        internal void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (this.rear == null)
            {
                this.front = this.rear = newnode;
            }
            else
            {
                this.rear.next = newnode;
                this.rear = newnode;
            }
            Console.WriteLine("{0} is inserted into queue", newnode.data);
        }
        internal void DeQueue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = this.front;
            this.front = this.front.next;
            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("{0} is deleted from the queue", temp.data);
        }
    }
}
