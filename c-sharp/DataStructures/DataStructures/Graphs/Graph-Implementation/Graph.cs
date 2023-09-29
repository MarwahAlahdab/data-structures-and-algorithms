using System;
namespace Graph_Implementation
{
  public class Graph
  {


    private Dictionary<string, List<Edge>> adjacencyList;

    public Graph()
    {
      adjacencyList = new Dictionary<string, List<Edge>>();
    }

    public class Edge
    {
      public string Vertex { get; }
      public int Weight { get; }

      public Edge(string vertex, int weight = 0)
      {
        Vertex = vertex;
        Weight = weight;
      }
    }

    public void AddVertex(string value)
    {
      if (!adjacencyList.ContainsKey(value))
      {
        adjacencyList[value] = new List<Edge>();
      }
    }

    public void AddEdge(string from, string to, int weight = 0)
    {
      if (adjacencyList.ContainsKey(from) && adjacencyList.ContainsKey(to))
      {
        adjacencyList[from].Add(new Edge(to, weight));
        adjacencyList[to].Add(new Edge(from, weight)); // For an undirected graph
      }
      else
      {
        throw new ArgumentException("Both vertices must exist in the graph.");
      }
    }



    public ICollection<string> GetVertices()
    {
      return adjacencyList.Keys;
    }



    public ICollection<Edge> GetNeighbors(string vertex)
    {
      if (adjacencyList.ContainsKey(vertex))
      {
        return adjacencyList[vertex];
      }
      return new List<Edge>();
    }



    public int Size()
    {
      return adjacencyList.Count;
    }






  }
}

