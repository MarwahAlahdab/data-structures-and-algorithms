using System;
using System.Xml.Linq;

namespace Graph_Implementation
{
  public class GraphWithNodes
  {



    private Dictionary<Node, List<Node>> adjacencyList;

    public GraphWithNodes()
    {
      adjacencyList = new Dictionary<Node, List<Node>>();
    }





    public Node AddNode(string value)
    {
      Node newNode = new Node(value);
      adjacencyList[newNode] = new List<Node>();
      return newNode;
    }

    public void AddEdge(Node node1, Node node2)
    {
      if (!adjacencyList.ContainsKey(node1) || !adjacencyList.ContainsKey(node2))
      {
        throw new InvalidOperationException("Both nodes must be in the graph.");
      }

      adjacencyList[node1].Add(node2);
      adjacencyList[node2].Add(node1);
    }




    // Breadth-first traversal - starting from a given node

    public IEnumerable<Node> BreadthFirst(Node startNode)
    {
      if (!adjacencyList.ContainsKey(startNode))
      {
        throw new InvalidOperationException("Start node not found !");
      }

      Queue<Node> queue = new Queue<Node>();
      HashSet<Node> visited = new HashSet<Node>();
      List<Node> result = new List<Node>();

      queue.Enqueue(startNode);
      visited.Add(startNode);

      while (queue.Count > 0)
      {
        Node currentNode = queue.Dequeue();
        result.Add(currentNode);

        foreach (Node neighbor in adjacencyList[currentNode])
        {
          if (!visited.Contains(neighbor))
          {
            queue.Enqueue(neighbor);
            visited.Add(neighbor);
          }
        }
      }

      return result;
    }







    public List<Node> DepthFirst(Node startNode)
    {
      List<Node> result = new List<Node>();
      HashSet<Node> visited = new HashSet<Node>();

      DepthFirstRecursive(startNode, visited, result);

      return result;

    }





    private void DepthFirstRecursive(Node currentNode, HashSet<Node> visited, List<Node> result)
    {
      if (currentNode == null || visited.Contains(currentNode))
      {
        return;
      }

      // Visit the current node
      visited.Add(currentNode);
      result.Add(currentNode);

      // Recursively visit neighbors
      foreach (var neighbor in currentNode.Neighbors)
      {
        DepthFirstRecursive(neighbor, visited, result);
      }
    }










  }



  public class Node
  {
    public string Value { get; set; }

    public List<Node> Neighbors  = new List<Node>();


    public Node(string value)
    {
      Value = value;
    }


    public void AddNeighbor(Node neighbor)
    {
      Neighbors.Add(neighbor);
    }


  }
}

