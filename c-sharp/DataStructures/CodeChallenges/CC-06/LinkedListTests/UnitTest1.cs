using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using static Program;

namespace LinkedListTests;
public class UnitTest1
{


  //Can successfully add a node to the end of the linked list
  //Can successfully add multiple nodes to the end of a linked list

  [Fact]
  public void Append_AddToEnd()
  {
    //Arrange
    Program.LinkedList list = new Program.LinkedList();

    //Act
    list.Append(2);
    list.Append(4);
    list.Append(6);

    string expected = "2 -> 4 -> 6";

    //Assert
    Assert.Equal(expected, list.PrintList());
  }



 



  //Can successfully insert a node before a node located in the middle of a linked list

  [Fact]
  public void InsertBefore_MiddleNode()
  {
    // Arrange
    LinkedList list = new LinkedList();
    list.Append(10);
    list.Append(20);
    list.Append(30);
    list.Append(40);
    list.Append(50);

    // Act
    list.InsertBefore(30, 25);

    // Assert
    string expected = "10 -> 20 -> 25 -> 30 -> 40 -> 50";
 
    Assert.Equal(expected, list.PrintList());
  }



  //Can successfully insert a node before the first node of a linked list

  [Fact]
  public void InsertBefore_FirstNode()
  {
    // Arrange
    LinkedList list = new LinkedList();
    list.Append(10);
    list.Append(20);
    list.Append(30);

    // Act
    list.InsertBefore(10, 5);

    // Assert
    string expectedList = "5 -> 10 -> 20 -> 30";
    string actualList = list.PrintList();
    Assert.Equal(expectedList, actualList);
  }







  //Can successfully insert after a node in the middle of the linked list

  [Fact]
  public void InsertAfter_MiddleNode()
  {
    // Arrange
    LinkedList list = new LinkedList();
    list.Append(10);
    list.Append(20);
    list.Append(30);
    list.Append(40);

    // Act
    list.InsertAfter(20, 25);

    // Assert
    string expectedList = "10 -> 20 -> 25 -> 30 -> 40";
    string actualList = list.PrintList();
    Assert.Equal(expectedList, actualList);
  }



  //Can successfully insert a node after the last node of the linked list


  [Fact]
  public void InsertAfter_LastNode()
  {
    // Arrange
    LinkedList list = new LinkedList();
    list.Append(10);
    list.Append(20);
    list.Append(30);

    // Act
    list.InsertAfter(30, 35);

    // Assert
    string expectedList = "10 -> 20 -> 30 -> 35";
    string actualList = list.PrintList();
    Assert.Equal(expectedList, actualList);
  }





}








