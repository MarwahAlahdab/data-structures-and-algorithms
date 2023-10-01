using Graph_Implementation;

internal class Program
{
  private static void Main(string[] args)
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

    IEnumerable<Node> breadthFirstResult = graph.BreadthFirst(pandora);

    foreach (Node node in breadthFirstResult)
    {
      Console.Write(node.Value + " ");
    }
  }
}