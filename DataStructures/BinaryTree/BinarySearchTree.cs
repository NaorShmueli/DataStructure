using BinaryTree.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinarySearchTree
    {
        public TreeNode Root { get; set; }

        public void Add(int value)
        {
            var newNode = new TreeNode(value);
            // If tree is empty, set new node as root
            if (Root == null)
            {
                Root = newNode;
            }
            // If tree is not empty, find the right spot for the new node
            else
            {
                var currentNode = Root;
                var traversing = true;
                while (traversing)
                {
                    if (currentNode.Value == newNode.Value)
                    {
                        //Assumption: Duplicates are not accepted.
                        traversing = false;
                    }
                    else if (currentNode.Value > newNode.Value)
                    {
                        // Traverse left of the node
                        if (currentNode.LeftChild == null)
                        {
                            //Add to the left of the current node
                            currentNode.LeftChild = newNode;
                            traversing = false;
                        }
                        else
                        {
                            //Traverse the left of the current node
                            currentNode = currentNode.LeftChild;
                        }

                    }
                    else if (currentNode.Value < newNode.Value)
                    {
                        // Traverse right of the node
                        if (currentNode.RightChild == null)
                        {
                            //Add to the right of the current node
                            currentNode.RightChild = newNode;
                            traversing = false;
                        }
                        else
                        {
                            //Traverse the left of the current node
                            currentNode = currentNode.RightChild;
                        }

                    }
                  
                }
            }
        }

        /// <summary>
        /// Traversal — Breadth-First Search
        /// By definition of BFS, we will be looking at all the nodes at the same level, before moving on to the next level
        /// </summary>
        /// <returns>Array of tree all tree values ordered by BFS algorithm</returns>
        public IList<int> BFS()
        {
            // Create a Queue to keep track of the nodes we have to visit
            var queue = new Queue<TreeNode>();
            // Create an Queue to store the visited node values
            var visited = new Queue<int>();
            // Start traversing from the root node
            queue.Enqueue(Root);

            // While the queue is not empty
            while (queue.Count != 0)
            {
                // Dequeue an element from the queue
                var current = queue.Dequeue();
                // Add the node value to the visited queue
                visited.Enqueue(current.Value);

                // If current node has left child, add it to the queue to be visited for
                if (current.LeftChild != null)
                {
                    queue.Enqueue(current.LeftChild);
                }
                // If current node has right child, add it to the queue to be visited for
                if (current.RightChild != null)
                {
                    queue.Enqueue(current.RightChild);
                }

            }
            return visited.ToList();
        }

        #region "DFS PreOrder Traversal"
        public IList<int> DFSPreOrderIterative()
        {
            // Create a stack to keep track of the node we visited
            var stack = new Stack<TreeNode>();
            // Create an Queue to return the data
            var visited = new Queue<int>();
            // Start traversing from the root node
            stack.Push(Root);

            // while we still have nodes in stack to backtrack
            while (stack.Count != 0)
            {
                // pop an element from the stack
                var current = stack.Pop();
                // Add the node value to the visited queue
                visited.Enqueue(current.Value);

                // Add the right node to the satck.
                if (current.RightChild != null)
                {
                    stack.Push(current.RightChild);
                }
                // Add the left node to the stack. We add left child after the rigth child node into the stack.
                // This is because we have to traverse left subtree before traversing right sub tree.
                if (current.LeftChild != null)
                {
                    stack.Push(current.LeftChild);
                }

            }
            return visited.ToList();
        }

        public IList<int> DFSPreOrderRecursive()
        {
            var current = Root;
            var visited = new Queue<int>();
            TraversePreOrder(current, visited);
            return visited.ToList();
           
        }

        private void TraversePreOrder(TreeNode node, Queue<int> visited)
        {
            visited.Enqueue(node.Value);
            if (node.LeftChild != null)
            {
                TraversePreOrder(node.LeftChild, visited);
            }
            if (node.RightChild != null)
            {
                TraversePreOrder(node.RightChild, visited);
            }
        }
        #endregion

        #region "DFS InOrder Traversal"

        /// <summary>
        /// Depth First Search Traversal - InOrder
        /// </summary>
        /// <returns>Returns the tree data in DFS InOrder</returns>
        public List<int> DFSInOrderIterative()
        {
            List<int> dfsData = new List<int>();
            Stack<TreeNode> visited = new Stack<TreeNode>();

            // start from root node (set current node to root node)
            TreeNode current = Root;

            // if current node is null and stack is also empty, we're done
            while (visited.Count > 0 || current != null)
            {
                // if current node is not null, push it to the stack (defer it)
                // and move to its left child
                if (current != null)
                {
                    visited.Push(current);
                    current = current.LeftChild;
                }
                else
                {
                    // else if current node is null, we pop an element from the stack,
                    // print it and finally set current node to its right child
                    current = visited.Pop();
                    dfsData.Add(current.Value);

                    current = current.RightChild;
                }
            }
            return dfsData;
        }



        public List<int> DFSInOrderRecursive()
        {
            var visited = new List<int>();
            TraverseInOrder(Root, visited);
            return visited;
        }

        private void TraverseInOrder(TreeNode node, List<int> visited)
        {
            if (node == null)
            {
                return;
            }
            TraverseInOrder(node.LeftChild, visited);
            visited.Add(node.Value);
            TraverseInOrder(node.RightChild, visited);
        }

        #endregion

        #region "DFS PostOrder Traversal"

        /// <summary>
        /// Depth First Search Traversal - PostOrder
        /// </summary>
        /// <returns>Returns the tree data in DFS Postorder</returns>
        public List<int> DFSPostOrderIterative()
        {
            List<int> dfsData = new List<int>();
            // create an empty stack and push root node
            Stack<TreeNode> visited = new Stack<TreeNode>();
            visited.Push(Root);

            // create another stack to store post-order traversal
            Stack<TreeNode> output = new Stack<TreeNode>();

            // run till stack is not empty
            while (visited.Count > 0)
            {
                // we pop a node from the stack and push the data to output stack
                TreeNode curr = visited.Pop();
                output.Push(curr);

                // push left and right child of popped node to the stack
                if (curr.LeftChild != null)
                {
                    visited.Push(curr.LeftChild);
                }

                if (curr.RightChild != null)
                {
                    visited.Push(curr.RightChild);
                }
            }

            // print post-order traversal
            while (output.Count > 0)
            {
                dfsData.Add(output.Pop().Value);
            }
            return dfsData;
        }



        public List<int> DFSPostOrderRecursive()
        {
            var dfsData = new List<int>();
            TraversePostOrder(Root, dfsData);
            return dfsData;
        }

        private void TraversePostOrder(TreeNode node, List<int> dfsData)
        {
            if (node == null)
            {
                return;
            }
            TraversePostOrder(node.LeftChild, dfsData);
            TraversePostOrder(node.RightChild, dfsData);
            dfsData.Add(node.Value);
        }

        #endregion
    }
}
