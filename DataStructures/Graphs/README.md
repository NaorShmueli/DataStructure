# Graphs

## Description

 A Graph is a data structure that contains a finite number of vertices (or nodes) and a finite set of edges connecting the vertices. In the above diagram, circles represent vertices, and lines represent edges connecting those vertices. We will find the usage of graphs in almost all of the software products we use in the real world. Some implementations of graphs include social networks, routing algorithms, mapping applications, recommendation engines, etc.

## Graph Types
 * Undirected: In an Undirected graph, edges are bidirectional. For example, you can reach vertex 1 from vertex 2, and also you can reach vertex 2 from vertex 1.
 * Directed: In a directed graph, edges are unidirectional/bi-directional. For example, you can reach vertex 1 from vertex 2, but you cannot reach vertex 2 from vertex 1 in our example here.
 * There are two other types of graphs. Weighted and Unweighted. In the weighted graph, edges will have a value associated with it. Edges in unweighted graphs do not have any values associated. For example, distance between two cities can be the weight of an edge that connected two cities.

![Undirected](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/undirected.JPG?raw=true)
![Directed](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/directed.JPG?raw=true)
![Weighted](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/weight.JPG?raw=true)

## Representation of graphs in code
 Any graph can be represented in two ways: Adjacency Matrix or Adjacency List. In the adjacency matrix representation, we will use a matrix structure to represent our graph. Indicies of row and column will represent the vertices and the values in each cell represent edges. We will mark a cell value to be 1 if there is an edge between two vertices, else it will be marked as 0.
 In the adjacency list representation, we will use an array structure to represent our graph. As shown in the below example, all the edges of a vertex are stored as a list of vertices.

![Representation](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/representation.JPG?raw=true)

## Operations O
 As we discussed in the beginning of the article, run times of a graph will depend on how the data is represented: adjacency list vs adjacency matrix.

![O](https://github.com/NaorShmueli/DataStructure/blob/master/DataStructures/Images/bigo.JPG?raw=true)

