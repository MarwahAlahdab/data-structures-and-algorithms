using static Program;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Xml;
using System.Text;

public class Program
{
  private static void Main(string[] args)
  {

    SinglyLinkedList sll1 = new SinglyLinkedList();
    Console.WriteLine(sll1.ToString());
    sll1.InsertToHead(5);
    sll1.InsertToHead(6);
    sll1.InsertToHead(1);
    Console.WriteLine(sll1.Includes(6));
    Console.WriteLine(sll1.ToString());



  }


  public class Node {

    public int data;
    public Node next;

    public Node(int data)
    {
      this.data = data;
      this.next = null;
    }

  }



  public class SinglyLinkedList{
    public Node head;

    public SinglyLinkedList()
    {
      head = null;
    }






    public void InsertToHead( int value)
    {

      Node newNode = new Node(value);

      if (head == null) {
        head = newNode;
        return;
      }
      

        newNode.next = head;
        head = newNode;



    }


    //    includes
    //Arguments: value
    //    Returns: Boolean
    //Indicates whether that value exists as a Node’s value somewhere within the list.

    public bool Includes(int value)  // check if exists

    {

      if (head.data == value)
        return true;

      Node current = head;

      while(current.next != null)
      {
        if (current.data == value)
          return true;
        current = current.next;
      }

      return false;


    }


    //    to string
    //Arguments: none
    //Returns: a string representing all the values in the Linked List, formatted as:
    //"{ a } -> { b } -> { c } -> NULL"


    public string ToString()
    {
      if (head == null)
      {
        return "NULL";
      }

      string result = "";
      Node currentNode = head;

      while (currentNode != null)
      {
        result += $"{{ {currentNode.data} }} -> ";
        currentNode = currentNode.next;
      }

      result += "NULL";
      return result;
    }



  }





}