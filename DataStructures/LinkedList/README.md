# Linked List 

## Description

A linked list is a linear collection of data elements, whose order is not given by their physical placement in memory. Instead, each element points to the next.
It’s basically a collection of nodes which are connected to its next node by a reference. A Node is essentially a class which has two properties: property to hold data and another property to hold a pointer to the next node in the collection. We can structure it as below:

## A linked list will mainly have

 * A property to hold the starting point of the collection: Head
 * A property to hold the end point of the collection: Tail
 * A property to hold the count of number of nodes in the collection: Length or Count
 * Methods to interact with the data within the collection: add, remove, find etc.

## Operations O

 * Search: If you have to find a node in a linked list, we have to go through each node in the list and compare it against the value we are looking for. So, it is O(n) where n is the number of node in the list. In best case scenario where the node you are looking for is at head, you just need one operation which will be O(1) and if the node is at the tail it will be O(n) in worst case. We say the average for a search operation is O(n)
 * Insert: A new node is mostly added at the beginning of the list in most of the implementation. So in any case (best, worst, average), it will only take 1 operation to add a node at the beginning of the list. Its O(1) for insert. We had implemented both the cases where we can insert at the end of the list and at the beginning of the list which is O(1) in both cases.
 * Delete: Delete is exactly the same as insert operation. It’s O(1) if we remove a node from the beginning and O(n) if we remove a node from the end. When we are delete a node at the end, we fist need to find the previous node of the tail and set the previous node as the new tail. For this, we have to traverse through the entire list which makes it O(n).

## Illustration  
![Structure](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/LinkedList.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
