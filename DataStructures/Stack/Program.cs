using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack.Implementation.Stack();
            Console.WriteLine("Push value str1 to stack");
            stack.Push("str1");
            Console.WriteLine($"Stack : {stack.PrintAll()}");
            Console.WriteLine("Push value str2 to stack");
            stack.Push("str2");
            Console.WriteLine($"Stack : {stack.PrintAll()}");
            Console.WriteLine("Push value str3 to stack");
            stack.Push("str3");
            Console.WriteLine($"Stack : {stack.PrintAll()}");
            Console.WriteLine($"Pop value");
            var popedVal = stack.Pop();
            Console.WriteLine($"Poped value : {popedVal}");
            Console.WriteLine($"Stack : {stack.PrintAll()}");
            Console.WriteLine($"Peek value");
            Console.WriteLine($"Peek : {stack.Peek()}");
        }
    }
}
