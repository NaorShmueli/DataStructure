using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Implementation
{
    class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int value)
        {
            Value = value;
        }
        public TreeNode()
        {

        }
    }
}
