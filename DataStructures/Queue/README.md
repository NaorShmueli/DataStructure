# Queue 

## Description

A queue is an abstract data structure that stores a collection of objects in the First In First Out (FIFO) approach.
What it means is that, we will be able to access the first element in the collection that was first added. For example, when you stand in a line for entering into a music concert, the first person who stood in line will be able to enter the concert hall first. And it will be the case for all the people in the line. In other words, when we add data into a queue data structure, you will be able to obtain the data in the same order. We will be adding data at the end of the queue and removing the data from the beginning of the queue.

## A Queue will mainly have

 * Enqueue: A method that allows us to add data elements at the end of the queue.
 * Dequeue: A method that allows us to remove an element from the queue. This will be the first element that was added to the queue.
 * Peek: A method that will allow us to look at the first element of the queue, without being removed from it. Some implementation does this using a property called top or first.
 * Size: A property to hold the count for the number of elements in the queue. This is also referred to as Count or Length in some implementations.

## Implementation

 A queue can be implemented in many ways. One way is to implement using an Array data structure.
 We can add elements to the end of the array and remove it from the beginning of the array. 
 But, when we remove an element from the beginning of an array, we need to reindex all the elements, which will be less efficient. 

## Operations O
 Queue is one of the most efficient data structures you can find if all you need to do is keep adding elements and removing/retrieving elements in the same order as they were added.

 * Insert/Delete: By the properties of Queue, FIFO; and with queue being implemented with a linked list, big O for these operations is always O(1). This is due to the fact that adding an element at the end/tail of the linked list or removing an element at the beginning/head of the linked list will always be one operation.
 * Access/Search: To find an element at a specific index or to verify if an element exists in a Queue, we have to loop through all the elements linearly. Because of this, these operations have a big O of O(n).

## Illustration 
![Structure](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/Queue.JPG?raw=true)
