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










  }



  public class Node
  {
    public string Value { get; set; }

    // public List<Node> Neighbors { get; set; }


    public Node(string value)
    {
      Value = value;
    }





  }
}

