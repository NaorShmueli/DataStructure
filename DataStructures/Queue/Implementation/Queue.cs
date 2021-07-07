using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Implementation
{
    class Queue
    {
        public Element First { get; set; }
        public Element Last { get; set; }
        public int Size { get; set; }

        /// <summary>
        /// Adds a new element to the end of the queue.
        /// </summary>
        /// <param name="value">New queue value</param>
        public void Enqueue(string value)
        {
            var newElement = new Element(value);
            
            if (Size == 0)
            {
                // If queue is empty, first and last will be the same.
                First = newElement;
                Last = newElement;
            }
            else
            {
                // Add the element at the end of the linked list
                Last.Next = newElement;
                Last = newElement;
            }
            Size++;
        }

        /// <summary>
        /// Removes an element from the beginning of the queue and returns its value
        /// </summary>
        /// <returns></returns>
        public string Dequeue()
        {
            if (Size == 0)
            {
                // If queue is empty, return default
                return default;
            }
            else
            {
                // Save the value to a temp variable
                var oldFirst = First;
                // Reset the first element to the next in line
                First = oldFirst.Next;
                // Remove the previour first node from the queue
                oldFirst.Next = null;
                Size--;
                return oldFirst.Value;
            }
        }

        /// <summary>
        /// Return the top value of the queue
        /// </summary>
        /// <returns></returns>
        public string Peek()
        {
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
