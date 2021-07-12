# Binary Search Tree 

## Description

 A Binary Tree is a tree data structure that will have at most two nodes as children, referred to as left and right nodes. There is no particular order for these nodes. are piling up 10 books on top of each other. You can only take the top book from the pile which is the one that was added recently.
 For a Binary Search Tree, there will be at most two child nodes — left and right, that are arranged in a particular order. The left child of a parent node will always have a smaller value compared to the parent node. The right child of a parent node will always have a larger value compared to the parent node. These conditions are true for the subtree of the child nodes as well. These properties will make search operations faster when the data is organized into a Binary Search Tree. Smaller values will always be in the left subtree and the larger values will always be in the right subtree.

## A Tree will mainly have

 * Add/Insert: A method that allows us to add new node to the tree.
 * Tree traversal: Breadth-First-Search (BFS) and Depth-First-Search (DFS)

## Implementation
## Tree Node
 * Value: To hold the data in our node.
 * LeftChild: To hold a reference to the left child node.
 * RightChild: To hold a reference to the right child node.

## DFS Algorithm
 * Inorder Traversal: is the one the most used variant of DFS(Depth First Search) Traversal of the tree.
   As DFS suggests, we will first focus on the depth of the chosen Node and then go to the breadth at that level. Therefore, we will start from the root node of the tree and go deeper-and-deeper into the left subtree with recursive manner.
   When we will reach to the left-most node with the above steps, then we will visit that current node and go to the left-most node of its right subtree(if exists).
 * Preorder Traversal: is another variant of DFS. Where atomic operations in a recursive function, are as same as Inorder traversal but with a different order.
   Here, we visit the current node first and then goes to the left sub-tree. After covering every node of the left sub-tree, we will move towards the right sub-tree and visit in a similar fashion.
 * Postorder Traversal: Similar goes with Postorder Traversal. Where we visit the left subtree and the right subtree before visiting the current node in recursion.

## Operations O
 Since BST has a unique property of storing all the lesser value nodes to the left and greater value nodes to the right, average time complexity for all operations such as access, search, insert and delete will be O(log n). This is because, we always reduce the amount of work to be done by half for every iteration due to the fact that, at every parent node, we choose to goto the left subtree or the right subtree but never both.
 
## Illustration 
![Structure](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/BinaryTree.JPG?raw=true)
