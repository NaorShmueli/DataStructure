# Stack 

## Description

A Stack is an abstract data structure that stores a collection of objects in the Last In First Out (LIFO) approach.
What it means is, the last or recent element that we add to stack is the first element that we will be able to retrieve. Imagine that you are piling up 10 books on top of each other. You can only take the top book from the pile which is the one that was added recently

## A Stack will mainly have

 * Push: A method that allows us to add data elements into the stack.
 * Pop: A method that allows us to remove an element from the Stack. This will be the top element on the stack.
 * Peek: A method that will allow us to look at the top element of the stack, without being removed from the stack. Some implementation does this using a property called top or first.
 * Size: A property to hold the count for number of elements in the stack. This is also referred to as Count or Length in some implementations.

## Implementation

 A Stack can be implemented in many ways. One way is to implement using an Array data structure. 
 We can add elements to the end of the array and remove it from the end of the array. 
 But, when it comes to dynamic resizing, an array is less efficient.

## Operations O
 Stack is one of the most efficient data structures you can find if all you need to do is keep adding elements and removing elements from the top.

 * Insert/Delete: By the properties of Stack, LIFO; and we implement Stack using a linked list, big O for these operations is always O(1). This is due to the fact that adding/removing an element from the head of the linked list is always takes only 1 operation.
 * Access/Search: To find an element at a specific index or to verify if an element exists in a Stack, we have to loop through all the elements linearly. Because of this, these operations have a big O of O(n).
 
## Illustration 
![Structure](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/Stack.JPG?raw=true)
