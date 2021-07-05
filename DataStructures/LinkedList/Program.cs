using System;
using LinkedList.Implementation;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList.Implementation.LinkedList();


            Console.WriteLine($"Linked Lists Count Is {linkedList.Count}");
            Console.WriteLine("Push 5 elements");
            linkedList.Push(1);
            linkedList.Push(2);
            linkedList.Push(3);
            linkedList.Push(4);
            linkedList.Push(5);
            linkedList.PrintList();
            Console.WriteLine("Pop: ");
            linkedList.Pop();
            linkedList.PrintList();
            Console.WriteLine("Shift: ");
            linkedList.Shift();
            linkedList.PrintList();
            Console.WriteLine("UnShift: 9");
            linkedList.UnShift(9);
            linkedList.PrintList();
            Console.WriteLine("Get node index 2");
            var node = linkedList.GetNodeByIndex(2);
            Console.WriteLine($"Node value = {node.Value}");
            Console.WriteLine("SET node index 2 to 55");
            linkedList.SetNodeByIndex(2,55);
            linkedList.PrintList();
            Console.WriteLine("Insert node index 2");
            linkedList.Insert(2, 500);
            linkedList.PrintList();
            Console.WriteLine("Remove node index 2");
            linkedList.Remove(2);
            linkedList.PrintList();
            Console.WriteLine("Reverse");
            linkedList.Reverse();
            linkedList.PrintList();
        }
    }
}
