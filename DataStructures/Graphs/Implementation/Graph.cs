using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs.Implementation
{
    class Graph
    {
        public IList<Vertex> AdjacencyList { get; set; }
        public Graph()
        {
            AdjacencyList = new List<Vertex>();
        }

        /// <summary>
        ///  A method to add a new vertex to the graph.
        /// </summary>
        /// <param name="vertex">newVertex</param>
        public void AddVertex(Vertex vertex)
        {
            if (AdjacencyList.Any(x => x.Name == vertex.Name))
            {
                //Exists vertex
                return;
            }
            AdjacencyList.Add(vertex);
        }

        /// <summary>
        /// Adds an edge to the graph.
        /// </summary>
        /// <param name="a">One of the vertices between an edge</param>
        /// <param name="b">Another vertex of an edge</param>
        public void AddEdge(Vertex a, Vertex b)
        {
            var findA = AdjacencyList.FirstOrDefault(x => x.Name == a.Name);
            var findB= AdjacencyList.FirstOrDefault(x => x.Name == a.Name);
            if (findA != null && findB != null)
            {
                findB.Edges.Add(a.Name);
                findA.Edges.Add(b.Name);
            }
            else
            {
                //Missing some vertex in graph
            }
        }

        /// <summary>
        /// Removes an edge between two vertices.
        /// </summary>
        /// <param name="a">One of the vertex of an edge to be removed</param>
        /// <param name="b">ANother vertex of an edge to be removed</param>
        public void RemoveEdge(Vertex a, Vertex b)
        {
            var findA = AdjacencyList.FirstOrDefault(x => x.Name == a.Name);
            var findB = AdjacencyList.FirstOrDefault(x => x.Name == a.Name);
            if (findA != null && findB != null)
            {
                findB.Edges.Remove(a.Name);
                findA.Edges.Remove(b.Name);
            }
            else
            {
                //Missing some vertex in graph
            }
        }

        #region "DFSTraversal"

        /// <summary>
        /// Recursively traverse the graph and return an array of vertex names
        /// </summary>
        /// <param name="startVertex">Name for the starting vertex from where the traversal should start.</param>
        /// <returns>Returns array of strings</returns>
        public List<string> DFSRecursive(string startVertex)
        {
            var start = AdjacencyList.FirstOrDefault(v => v.Name == startVertex);
            if (start == null) return null;

            // List to keep track of the result
            List<string> result = new List<string>();

            // Lookup for keep track of visited nodes
            HashSet<string> visited = new HashSet<string>();

            Traverse(start, result, visited);
            return result;
        }

        private void Traverse(Vertex startVertex, List<string> result, HashSet<string> visited)
        {
            if (startVertex == null || visited.Contains(startVertex.Name)) return;

            //Add the vertex to the visited list
            result.Add(startVertex.Name);

            // Mark the vertex as visited
            visited.Add(startVertex.Name);

            // Traverse through the neighbors of the vertex
            foreach (var neighbor in startVertex.Edges)
            {
                // If the neighbor vertex is not visited already, perform DFS on the neighbor vertex
                if (!visited.Contains(neighbor))
                {
                    Traverse(AdjacencyList.FirstOrDefault(v => v.Name == neighbor), result, visited);
                }
            }
        }

        /// <summary>
        /// Iteratively traverse the graph and return an array of vertex names
        /// </summary>
        /// <param name="startVertex">Name for the starting vertex from where the traversal should start.</param>
        /// <returns>Returns array of strings</returns>
        public List<string> DFSIterative(string startVertex)
        {
            Vertex start = AdjacencyList.FirstOrDefault(v => v.Name == startVertex);
            if (start == null) return null;

            List<string> result = new List<string>();
            HashSet<string> visited = new HashSet<string>();
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (visited.Contains(current.Name)) continue;
                result.Add(current.Name);
                visited.Add(current.Name);

                foreach (var neighbor in current.Edges)
                {
                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(AdjacencyList.FirstOrDefault(v => v.Name == neighbor));
                    }
                }
            }
            return result;
        }

        #endregion

        /// <summary>
        /// Iteratively traverse the graph and return an array of vertex names
        /// </summary>
        /// <param name="startVertex">Name for the starting vertex from where the traversal should start.</param>
        /// <returns>Returns array of strings</returns>
        public List<string> BFSTraversal(string startVertex)
        {
            Vertex start = AdjacencyList.FirstOrDefault(v => v.Name == startVertex);
            if (start == null) return null;

            List<string> result = new List<string>();
            HashSet<string> visited = new HashSet<string>();
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                // If current vertex is already visited, move to the next vertex in the queue
                if (visited.Contains(current.Name)) continue;

                result.Add(current.Name);
                visited.Add(current.Name);

                foreach (var neighbor in current.Edges)
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(AdjacencyList.FirstOrDefault(v => v.Name == neighbor));
                    }
                }
            }

            return result;

        }
    }
}
