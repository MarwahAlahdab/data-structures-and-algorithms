using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using static Program;

public class Program
{
  private static void Main(string[] args)
  {

    LinkedList list1 = new LinkedList();

    list1.Append(10);
    list1.Append(20);
    list1.Append(30);

    try
    {
      list1.InsertBefore(30, 3);
      list1.InsertAfter(30, 40);
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine(ex.Message );
    }


    Console.WriteLine(list1.PrintList());

  }







  public class Node
  {
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int Data)
    {
      this.Data = Data;
      this.Next = null;
    }




  }








  public class LinkedList
  {
    public Node head;



    public LinkedList(){

      head = null;
     }


    public bool IsEmpty()
    {
      if (head == null)
        return true;

      return false;
    }




    public void Append(int newValue)
    {

      Node newNode = new Node(newValue);

      if (IsEmpty()) {
        head = newNode;
        return;
      }
       

      if(head.Next == null)
      {
        head.Next = newNode;
        return;
      }

      Node current = head;

      while(current.Next != null)
      {
        current = current.Next;

      }

      current.Next = newNode;
    }


    //    insert before
    //arguments: value, new value
    //adds a new node with the given new value immediately before the first node that has the value specified


    public void InsertBefore(int value, int newValue)
    {

      Node val = new Node(value);
      Node newNode = new Node(newValue);

      Node current = head;

      if (current.Data == val.Data) {
        newNode.Next = head;
        head = newNode;
        return;
      }




      while (current.Next != null && current.Next.Data != val.Data)
      {
        current = current.Next;
      }


      if (current.Next == null)
      {
        throw new ArgumentException("Value not found in the list!");
      }

      newNode.Next = current.Next;
      current.Next = newNode;





    }











    //    insert after
    //    arguments: value, new value
    //    adds a new node with the given new value immediately after the first node that has the value specified

    public void InsertAfter(int value, int newValue)
    {


      Node val = new Node(value);
      Node newNode = new Node(newValue);

      Node current = head;

      if (current.Data == val.Data)
      {
        newNode.Next = current.Next;
        current.Next = newNode;
        return;
      }
     
        

      while (current != null && current.Data != val.Data)
      {
        current = current.Next;
      }


      if (current == null)
      {
        throw new ArgumentException("Value not found in the list!");
      }

      newNode.Next = current.Next;
      current.Next = newNode;


    }







    public string PrintList()
    {
      Node current = head;
      StringBuilder sb = new StringBuilder();

      while (current != null)
      {
        sb.Append(current.Data);

        if (current.Next != null)
        {
          sb.Append(" -> ");
        }

        current = current.Next;
      }

      return sb.ToString();
    }






  }









}