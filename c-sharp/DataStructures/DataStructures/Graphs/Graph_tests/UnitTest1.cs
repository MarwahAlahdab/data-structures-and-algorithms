using Graph_Implementation;

namespace Graph_tests;

public class UnitTest1
{



  [Fact]
  public void AddVertex_AddVertexToGraph()
  {
    var graph = new Graph();

    graph.AddVertex("A");

    
    Assert.Contains("A", graph.GetVertices());
  }

  [Fact]
  public void AddEdge_ShouldAddEdgeBetweenVertices()
  {
   
    var graph = new Graph();
    graph.AddVertex("A");
    graph.AddVertex("B");

  
    graph.AddEdge("A", "B", 5);

    var neighbors = graph.GetNeighbors("A");
    Assert.Equal(1, neighbors.Count);
  }



  [Fact]
  public void GetVertices_ReturnAllVertices()
  {
    var graph = new Graph();
    graph.AddVertex("A");
    graph.AddVertex("B");
    graph.AddVertex("C");

    var vertices = graph.GetVertices();

    Assert.Contains("A", vertices);
    Assert.Contains("B", vertices);
    Assert.Contains("C", vertices);
  }

  [Fact]
  public void GetNeighbors_ReturnNeighborsOfVertex()
  {
    var graph = new Graph();
    graph.AddVertex("A");
    graph.AddVertex("B");
    graph.AddVertex("C");
    graph.AddEdge("A", "B", 5);
    graph.AddEdge("A", "C", 3);


    var neighbors = graph.GetNeighbors("A");


    Assert.Equal(2, neighbors.Count);
    Assert.Contains(neighbors, e => e.Vertex == "B" && e.Weight == 5);
    Assert.Contains(neighbors, e => e.Vertex == "C" && e.Weight == 3);
  }

  [Fact]
  public void Size_ReturnNumberOfVertices()
  {
    var graph = new Graph();
    graph.AddVertex("A");
    graph.AddVertex("B");
    graph.AddVertex("C");

    int size = graph.Size();

    Assert.Equal(3, size);
  }

  [Fact]
  public void AddEdge_ThrowArgumentException_IfVerticesNotExist()
  {
    var graph = new Graph();

    Assert.Throws<ArgumentException>(() => graph.AddEdge("A", "B", 5));
  }



}

