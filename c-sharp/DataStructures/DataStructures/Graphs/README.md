# Graph Implementation

## Description
This C# implementation provides a basic graph data structure represented as an adjacency list. The graph class allows you to add vertices, add edges between vertices (with optional weights), get all vertices, get neighbors of a specific vertex, and get the size of the graph.



## Approach & Efficiency
### `AddVertex(string value)`
This method adds a new vertex to the graph. It has a time complexity of O(1).

### `AddEdge(string start, string end, int weight = 0)`
This method adds a new edge between two vertices in the graph. Both vertices should already exist in the graph. It has a time complexity of O(1).

### `GetVertices()`
This method returns all vertices in the graph as a collection. If there are no vertices, it returns an empty collection. It has a time complexity of O(V), where V is the number of vertices.

### `GetNeighbors(string vertex)`
This method returns a collection of edges connected to the given vertex, including the weight of the connection. If there are no neighbors, it returns an empty collection. It has a time complexity of O(E), where E is the number of edges.

### `Size()`
This method returns the total number of vertices in the graph. If there are no vertices, it returns 0. It has a time complexity of O(1).
