using System.Xml.Linq;
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


  //CC-36

  [Fact]
  public void BreadthFirst_ReturnCorrectBFT()
  {


    GraphWithNodes graph = new GraphWithNodes();
    Node pandora = graph.AddNode("Pandora");
    Node arendelle = graph.AddNode("Arendelle");
    Node metroville = graph.AddNode("Metroville");
    Node monstropolis = graph.AddNode("Monstropolis");
    Node narnia = graph.AddNode("Narnia");
    Node naboo = graph.AddNode("Naboo");

    graph.AddEdge(pandora, arendelle);
    graph.AddEdge(arendelle, metroville);
    graph.AddEdge(arendelle, monstropolis);
    graph.AddEdge(metroville, monstropolis);
    graph.AddEdge(metroville, narnia);
    graph.AddEdge(metroville, naboo);
    graph.AddEdge(monstropolis, naboo);
    graph.AddEdge(narnia, naboo);

    IEnumerable<Node> traversal = graph.BreadthFirst(pandora);


    List<string> result = new List<string>();

    foreach (Node node in traversal)
    {
      result.Add(node.Value);
    }

    string expected = "Pandora Arendelle Metroville Monstropolis Narnia Naboo";
    string actual = string.Join(" ", result);
    Assert.Equal(expected, actual);
  }



  //CC-37

  [Fact]
  public void TestBusinessTrip()
  {
    // Arrange
    var cityMap = new CityMap();
    cityMap.AddRoute("Metroville", "Pandora", 82);
    cityMap.AddRoute("Arendelle", "Pandora", 150);

    cityMap.AddRoute("Arendelle", "Metroville", 99);


    cityMap.AddRoute("Metroville", "Monstropolis", 105);
    cityMap.AddRoute("Naboo", "Metroville", 26);
    cityMap.AddRoute("Metroville", "Narnia", 37);
    cityMap.AddRoute( "Narnia", "Naboo", 250);
    cityMap.AddRoute("Arendelle", "Monstropolis", 42);

    cityMap.AddRoute("Monstropolis","Naboo", 73);



    // Act
    string[] trip1 = { "Metroville", "Pandora" };
    string[] trip2 = { "Arendelle", "Monstropolis", "Naboo" };
    string[] trip3 = { "Naboo", "Pandora" };
    string[] trip4 = { "Narnia", "Arendelle", "Naboo" };

    int? tripCost1 = CityMap.BusinessTrip(cityMap, trip1);
    int? tripCost2 = CityMap.BusinessTrip(cityMap, trip2);
    int? tripCost3 = CityMap.BusinessTrip(cityMap, trip3);
    int? tripCost4 = CityMap.BusinessTrip(cityMap, trip4);

    // Assert
    Assert.Equal(82, tripCost1);
    Assert.Equal(115, tripCost2);
    Assert.Null(tripCost3); // Should return null for non-existent route
    Assert.Null(tripCost4); 
  }




  //CC-38


  [Fact]
    public void TestDepthFirstTraversal()
    {

    GraphWithNodes graph = new GraphWithNodes();

    Node nodeA = graph.AddNode("A");
    Node nodeB = graph.AddNode("B");
    Node nodeC = graph.AddNode("C");
    Node nodeD = graph.AddNode("D");
    Node nodeE = graph.AddNode("E");
    Node nodeF = graph.AddNode("F");
    Node nodeG = graph.AddNode("G");
    Node nodeH = graph.AddNode("H");

    nodeA.AddNeighbor(nodeB);
    nodeB.AddNeighbor(nodeC);
    nodeC.AddNeighbor(nodeG);

    nodeA.AddNeighbor(nodeD);
    nodeB.AddNeighbor(nodeD);
    nodeD.AddNeighbor(nodeE);
    nodeD.AddNeighbor(nodeH);

    nodeD.AddNeighbor(nodeF);
    nodeF.AddNeighbor(nodeH);


    List<Node> traversalResult = graph.DepthFirst(nodeA);

    List<string> nodeValues = new List<string>();
    foreach (var node in traversalResult)
    {
      nodeValues.Add(node.Value);
    }

    List<string> expectedValues = new List<string> { "A", "B", "C", "G", "D", "E", "H", "F" };

    Assert.Equal(expectedValues, nodeValues);
  }





  }



