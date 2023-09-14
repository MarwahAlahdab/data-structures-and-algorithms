using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HashTables
{

  public class HashMap
  {

    // Buckets == a pre determined (size) array 


    // The map is an array of linkedlsit, where each linked list contains key-value pairs.
    private LinkedList<KeyValuePair<string, string>>[] Map { get; set; }


    public HashMap(int size)
    {
      Map = new LinkedList<KeyValuePair<string, string>>[size];
    }


    public int Hash(string key)
    {
      int hashValue = 0;

      char[] letters = key.ToCharArray();

      for (int i = 0; i < letters.Length; i++)
      {
        hashValue += letters[i]; /// Integer representation (ASCII)
      }


      //0 - 9
      hashValue = (hashValue * 599) % Map.Length; //return location within the array size range

      return hashValue;
    }





    public void Set(string key, string value)
    {
      int hashKey = Hash(key);

      if (Map[hashKey] == null) //if the bucket at this location (index) is null
      {
        Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
        //initialize a new linked list at that index to hold key-value pairs.
      }

      //key and value that we want to store
      KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);

      Map[hashKey].Insert(entry);

    }



    public void Print()
    {
      for (int i = 0; i < Map.Length; i++)
      {

        if (Map[i] == null)
        {
          Console.WriteLine($"Bucket {i}: Empty");
        }

        else
        {
          Console.WriteLine($"Bucket {i}");

          Node<KeyValuePair<string, string>> current = Map[i].Head;

          while (current != null)
          {
            Console.Write($"[{current.Value.Key}] : [{current.Value.Value}] =>");

            current = current.Next;
          }
        }

      }
    }



    public string Get(string key)
    {
      // What bucket this key in
      // Hash(key) wiil give us the index on the map


      // travrese the linkedlist (if it is there)
      // Examine the node one by pne and if the key we are looking for 
      // return the value


      for (int i = 0; i < Map.Length; i++)
      {
        if (Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while (current != null)
          {
            if (current.Value.Key == key)
            { return current.Value.Value; }
            current = current.Next;
          }
        }
      }
      return null;



    }

    public bool Has(string key)
    {
      // What bucket this key in
      // Hash(key) wiil give us the index on the map

      // travrese the linkedlist (if it is there)
      // Examine the node one by pne and if the key we are looking for 
      // return true/ false if we found it

      for (int i = 0; i < Map.Length; i++)
      {
        if (Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while (current != null)
          {
            if (current.Value.Key == key)
            { return true; }
            current = current.Next;
          }
        }
      }
      return false;

    }




    public List<string> Keys()
    {
      List<string> list = new List<string>();
      for (int i = 0; i < Map.Length; i++)
      {
        if (Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while (current != null)
          {
            list.Add(current.Value.Key);
            current = current.Next;
          }
        }
      }
      return list;
    }






  }

    }




