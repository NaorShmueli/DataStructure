using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Implementation
{
    public class LinkedList
    {
        public ListNode Head { get; set; }
        public ListNode Tail { get; set; }
        public int Count { get; set; }

        /// <summary>
        /// Adds a node to the end of the linked list
        /// </summary>
        /// <param name="value">Value to be stored in the linked list node</param>
        public void Push(int value)
        {
            var newNode = new ListNode(value);

            // If head is null (empty linked list), then assign both head and tail to the new node
            if (Head == null)
            {
                Head = newNode;
                Head.Next = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            // Increment the length of the linked list
            Count++;
        }
        /// <summary>
        /// Removes a node at the end of the linked list and will return the node value
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (Count == 0)
            {
                return default;
            }
            else if (Head == Tail)
            {
                // List only has one node. Return the data and reset the list to be empty
                var nodeToReturn = Head;
                Head = null;
                Tail = null;
                Count = 0;
                return nodeToReturn.Value;
            }
            else
            {
                ListNode currentNode = Head;
                ListNode newTailNode = null;

                // Find the node before the tail node
                while (currentNode.Next != null)
                {
                    newTailNode = currentNode;
                    currentNode = currentNode.Next;
                }
                ListNode returnNode = Tail;

                // Set the tail to the new tail node
                Tail = newTailNode;
                newTailNode.Next = null;
                // Decrement the length
                Count--;
                return returnNode.Value;
            }
        }
        /// <summary>
        /// Removes a node form the beginning of the linked list and will return the node value
        /// </summary>
        /// <returns></returns>
        public int Shift()
        {
            // List is empty
            if (Count == 0)
            {

                return default;
            }

            // List has only one node. Reset the list and return the data
            else if (Head == Tail)
            {
                var nodeToReturn = Head;
                Head = null;
                Tail = null;
                Count = 0;
                return nodeToReturn.Value;
            }
            else
            {
                // Save head to a temp variable.
                var oldHead = Head;
                // Set head to the next node of the prev head
                var newHead = Head.Next;
                // Isolate the prev head from the list
                oldHead.Next = null;
                Head = newHead;
                // Decrement the length
                Count--;
                return oldHead.Value;
            }
        }

        /// <summary>
        /// Adds a node at the beginning of the linked list
        /// </summary>
        /// <param name="value">Value to be stored at the beginning of the linked list</param>
        public void UnShift(int value)
        {
            var newNode = new ListNode(value);
            // List is empty, set both head and tail to the new node
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            // List is not empty. So, set the new node.next to the head
            // and repoint head to the new node
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            // Increment the length 
            Count++;
        }
        /// <summary>
        /// Returns the node at the specified index of the linked list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Index of the node to be retrieved</returns>
        public ListNode GetNodeByIndex(int index)
        {
            // If lenght is zero or if the index is not a valid number
            if (Count == 0 || index > Count - 1 || index < 0)
            {
                return default;

            }
            // loop through the list from head and find the node
            var returnNode = Head;
            for (int i = 1; i < index; i++)
            {
                returnNode = returnNode.Next;
            }
            return returnNode;
        }

        /// <summary>
        /// Updates the value of the node at the specified index.
        /// </summary>
        /// <param name="index">Index of the node to be updated</param>
        /// <param name="value">New value of the node</param>
        /// <returns></returns>
        public bool SetNodeByIndex(int index, int value)
        {

            // Find the node at the specified index
            var node = GetNodeByIndex(index);
            var result = false;
            if (node != null)
            {
                // Update the value of the node if the node is valid.
                node.Value = value;
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        /// <summary>
        /// Inserts a new node at the specified index.
        /// </summary>
        /// <param name="index">Index at which the new node has to be inserted</param>
        /// <param name="value"> Value of the new node to be inserted</param>
        /// <returns>If succeed</returns>
        public bool Insert(int index, int value)
        {
            var result = false;

            if (index < 0 || index > Count)
            {

            }
            else if (index == 0)
            {
                // Add the new node at the beginning of the list
                UnShift(value);
                result = true;
            }
            else if (index == Count)
            {
                // Add the new node at the end of the list
                Push(value);
                result = true;
            }
            else
            {
                // Find the two nodes betwen which we have to insert a new node
                var prevNode = GetNodeByIndex(index - 1);
                var nextNode = prevNode.Next;

                // Create a new node and insert between the two node
                var newNode = new ListNode(value);
                prevNode.Next = newNode;
                newNode.Next = nextNode;

                // Increment length
                Count++;
                result = true;
            }
            return result;

        }
        /// <summary>
        /// Removes a node at the specified index and returns its value.
        /// </summary>
        /// <param name="index">Index at which the node has to be removed.</param>
        /// <returns>The value of removed node</returns>
        public int Remove(int index)
        {
            if (index < 0 || index > Count)
            {
                return default;
            }
            else if (index == 0)
            {
                // Remove the node at the beginning of the list
                return Shift();
            }
            else if (index == Count - 1)
            {
                // Remove a node at the end of the list
                return Pop();
            }
            else
            {
                // Find the node after which we have to remove a node
                var prevNode = GetNodeByIndex(index - 1);
                var removeNode = prevNode.Next;

                // Set the next pointer of the previous node to the next pointer of the node to be removed.
                prevNode.Next = removeNode.Next;

                // Isolate the node from the list
                removeNode.Next = null;

                // Decrement the counter
                Count--;

                // Return the node value
                return removeNode.Value;
            }

        }
        /// <summary>
        /// Reverses the order of the elements in linked list
        /// </summary>
        public void Reverse()
        {
            //Swap head and tail nodes
            var currentNode = Head;
            Head= Tail;
            Tail = currentNode;

            // Temp variables to store the references
            ListNode prevNode = null;
            ListNode nextNode;

            // Update the next pointers of each node in the list
            for (var i = 0; i < Count; i++)
            {
                nextNode = currentNode.Next;
                currentNode.Next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }
        }

        public void PrintList()
        {
            var current = Head;
            var sb = new StringBuilder();
            for(var i = 0; i < Count; i++)
            {

                sb.Append(current.Value);
                sb.Append(",");
                current = current.Next;

            }
           sb =  sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb.ToString());

        }
    }
}
