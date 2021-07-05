using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Implementation
{
   public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int nodeValue)
        {
            Value = nodeValue;
        }

    }
}
