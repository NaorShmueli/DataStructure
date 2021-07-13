using Graphs.Implementation;
using System;
using System.Linq;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            var holon = new Vertex("Holon");
            var batyam = new Vertex("Bat-Yam");
            var telaviv = new Vertex("Tel-Aviv");
            var rishon = new Vertex("Rishon Lezion");
            var azur = new Vertex("Azur");
            var givatayim = new Vertex("Givatayim");
            graph.AddVertex(holon);
            graph.AddVertex(batyam);
            graph.AddVertex(telaviv);
            graph.AddVertex(rishon);
            graph.AddVertex(azur);
            graph.AddVertex(givatayim);

            graph.AddEdge(holon, batyam);
            graph.AddEdge(holon, telaviv);
            graph.AddEdge(batyam, telaviv);
            graph.AddEdge(telaviv, rishon);
            graph.AddEdge(batyam, azur);
            graph.AddEdge(azur, givatayim);
            graph.AddEdge(givatayim, telaviv);

            var holonBfs = graph.BFSTraversal("Holon");
            Console.WriteLine("Holon BFS:");

            Console.WriteLine(holonBfs.Aggregate((a, b) => a + "-->" + b));
            var holonDfs = graph.DFSIterative("Holon");

            Console.WriteLine("Holon DFS (Iterative):");
            Console.WriteLine(holonDfs.Aggregate((a, b) => a + "-->" + b));
            holonDfs = graph.DFSRecursive("Holon");

            Console.WriteLine("Holon DFS (Recursive):");
            Console.WriteLine(holonDfs.Aggregate((a, b) => a + "-->" + b));
        }
    }
}
