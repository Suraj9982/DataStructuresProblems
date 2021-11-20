using System;

namespace DataStructuresComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            Console.WriteLine("DATA STRUCTURES");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION\n1.Add simple linkedlist\n2.Add In Reverse\n3.Exit");
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
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 3");
                        break;
                }
            }   
        }
    }
}
