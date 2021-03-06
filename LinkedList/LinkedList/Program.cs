using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            Console.WriteLine("The list before inserting 30 is : ");
            list.Display();
            list.InsertAtParticularPosition(3, 30);
            Console.WriteLine("The list after inserting 30 is : ");
            list.Display();
            list.RemoveLastNode();
            Console.WriteLine("The list after removing last node is : ");
            list.Display();
        }
    }
}