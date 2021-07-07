using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue.Implementation.Queue();
            Console.WriteLine("Enqueue value str1 to queue");
            queue.Enqueue("str1");
            Console.WriteLine($"Queue : {queue.PrintAll()}");
            Console.WriteLine("Enqueue value str2 to queue");
            queue.Enqueue("str2");
            Console.WriteLine($"Queue : {queue.PrintAll()}");
            Console.WriteLine("Enqueue value str3 to queue");
            queue.Enqueue("str3");
            Console.WriteLine($"Queue : {queue.PrintAll()}");
            Console.WriteLine($"Dequeue value");
            var popedVal = queue.Dequeue();
            Console.WriteLine($"Dequeued value : {popedVal}");
            Console.WriteLine($"Queue : {queue.PrintAll()}");
            Console.WriteLine($"Peek value");
            Console.WriteLine($"Peek : {queue.Peek()}");
        }
    }
}
