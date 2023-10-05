using System;
namespace Graph_Implementation
{
  public class CityMap
  {
    public Dictionary<string, Dictionary<string, int>> graph;


    public CityMap()
    {
      graph = new Dictionary<string, Dictionary<string, int>>();
    }

    public void AddRoute(string source, string destination, int cost)
    {
      if (!graph.ContainsKey(source))
      {
        graph[source] = new Dictionary<string, int>();
      }
      graph[source][destination] = cost;
    }

    public int GetCost(string source, string destination)
    {
      if (graph.ContainsKey(source) && graph[source].ContainsKey(destination))
      {
        return graph[source][destination];
      }
      return -1; // Return -1 if the route is not found
    }


    //CC-37



    public static int? BusinessTrip(CityMap cityMap, string[] cities)
    {
      int totalCost = 0;

      for (int i = 0; i < cities.Length - 1; i++)
      {
        string currentCity = cities[i];
        string nextCity = cities[i + 1];

        // Check if there is a direct flight between currentCity and nextCity
        int cost = cityMap.GetCost(currentCity, nextCity);

        if (cost == -1)
        {
          // No direct flight, trip is not possible
          return null;
        }

        totalCost += cost;
      }

      return totalCost;
    }

  }


}

