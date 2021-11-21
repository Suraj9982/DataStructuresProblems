using System;

namespace DataStructuresComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            StackOperations stack = new StackOperations();
            QueueOperation queue = new QueueOperation();
            Console.WriteLine("DATA STRUCTURES");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nCHOOSE OPTION\n1.Add simple linkedlist\n2.Add In Reverse\n3.Insert At Particular postion\n4.Remove First Node\n5.RemoveLastNode\n6.Push into Stack\n7.Peek into Stack\n8.Pop from stack\n9.Inser into Queue\n10.exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linked.Adddata(56);
                        linked.Adddata(30);
                        linked.Adddata(70);
                        break;
                    case 2:
                        linked.AddInReverseOrder(70);
                        linked.AddInReverseOrder(30);
                        linked.AddInReverseOrder(56);
                        linked.Display();
                        break;
                    case 3:
                        linked.Adddata(56);
                        linked.Adddata(70);
                        linked.InsertAtPostion(1, 30);
                        linked.Display();
                        break;
                    case 4:
                        linked.RemoveFirstnode();
                        linked.Display();
                        break;
                    case 5:
                        linked.RemovelastNode();
                        linked.Display();
                        break;
                    case 6:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Peek();
                        break;
                    case 7:
                        stack.Peek();
                        break;
                    case 8:
                        stack.Pop();
                        stack.Peek();
                        break;
                    case 9:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        break;
                    case 10:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 9");
                        break;
                }
            }   
        }
    }
}
