using System;

namespace DataStructuresComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            StackOperations stack = new StackOperations();
            Console.WriteLine("DATA STRUCTURES");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nCHOOSE OPTION\n1.Add simple linkedlist\n2.Add In Reverse\n3.Insert At Particular postion\n4.Remove First Node\n5.RemoveLastNode\n6.Search the data\n7.search and insert new data on postion\n8.Push into stack\n9.Peek into Stack\n10.Pop from stack\n11.Exit");
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
                        Console.WriteLine("enter the number you want to search");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int search=linked.Search(num);
                        Console.WriteLine(search);
                        break;
                    case 7:
                        int postion = linked.Search(30);
                        linked.InsertAtPostion(postion, 40);
                        linked.Display();
                        break;
                    case 8:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Peek();
                        break;
                    case 9:
                        stack.Peek();
                        stack.Display();
                        break;
                    case 10:
                        stack.PeekAndPop();
                        stack.Display();
                        break;
                    case 11:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 11");
                        break;
                }
            }   
        }
    }
}
