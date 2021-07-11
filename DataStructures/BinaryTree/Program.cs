using System;
using System.Linq;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(10);
            binarySearchTree.Add(6);
            binarySearchTree.Add(3);
            binarySearchTree.Add(8);
            binarySearchTree.Add(0);
            binarySearchTree.Add(15);
            binarySearchTree.Add(11);
            binarySearchTree.Add(20);


            var a = binarySearchTree.DFSInOrderIterative();
            var str = a.Select(z => z.ToString()).Aggregate((x, y) => x + "," + y);
            Console.WriteLine("DFSInOrderIterative:");
            Console.WriteLine(str);

            var b = binarySearchTree.DFSInOrderRecursive();
            str = b.Select(z => z.ToString()).Aggregate((x, y) => x + "," + y);
            Console.WriteLine("DFSInOrderRecursive:");
            Console.WriteLine(str);

            var c = binarySearchTree.DFSPreOrderIterative();
            str = c.Select(z => z.ToString()).Aggregate((x, y) => x + "," + y);
            Console.WriteLine("DFSPreOrderIterative:");
            Console.WriteLine(str);

            var d = binarySearchTree.DFSPreOrderRecursive();
            str = d.Select(z => z.ToString()).Aggregate((x, y) => x + "," + y);
            Console.WriteLine("DFSPreOrderRecursive:");
            Console.WriteLine(str);

            var e = binarySearchTree.DFSPostOrderIterative();
            str = e.Select(z => z.ToString()).Aggregate((x, y) => x + "," + y);
            Console.WriteLine("DFSPostOrderIterative:");
            Console.WriteLine(str);

            var f = binarySearchTree.DFSPostOrderRecursive();
            str = f.Select(z => z.ToString()).Aggregate((x, y) => x + "," + y);
            Console.WriteLine("DFSPostOrderRecursive:");
            Console.WriteLine(str);

            var g = binarySearchTree.BFS();
            str = g.Select(z => z.ToString()).Aggregate((x, y) => x + "," + y);
            Console.WriteLine("BFS:");
            Console.WriteLine(str);
        }
    }
}
