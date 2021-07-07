using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Implementation
{
    class Stack
    {
        public Element First { get; set; }
        public Element Last { get; set; }
        public int Size { get; set; }

        public Stack(string value)
        {
            Push(value);
        }

        public Stack()
        {

        }

        /// <summary>
        /// Adds a new element to the top of the stack.
        /// </summary>
        /// <param name="value">New stack value</param>
        public void Push(string value)
        {
            var newElemet = new Element(value);
            if (Size==0)
            {
                // If list is empty, first and last will become the new node
                First = newElemet;
                Last = newElemet;
            }
            else
            {
                // Add the element at the beginning of the linked list
                newElemet.Next = First;
                First = newElemet;
            }
            Size++;
        }

        /// <summary>
        /// Removes an element from the top of the stack and returns its value
        /// </summary>
        /// <returns></returns>
        public string Pop()
        {
            // If stack is empty, return default
            if (Size == 0)
            {
                return default;
            }
            else
            {
                // Save the first element to a temp variable
                var oldFirst = First;
                // Set the first element to be next of the previous first
                First = oldFirst.Next;
                // Remove the node the stack
                oldFirst.Next = null;
                Size--;
                return oldFirst.Value;

            }
        }

        /// <summary>
        /// Return the top value of the stack
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
            // If stack is empty, return default
            if (Size == 0)
            {
                return default;
            }
            else
            {
                return First.Value;

            }
        }

        public string PrintAll()
        {
            var current = First;
            var sb = new StringBuilder();
            for (var i = 0; i < Size; i++)
            {

                sb.Append(current.Value);
                sb.Append(",");
                current = current.Next;

            }
            sb = sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
