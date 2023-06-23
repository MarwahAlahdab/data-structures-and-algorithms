using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using static Program;

namespace SLLTests;

public class UnitTest1
{

  //Can successfully instantiate an empty linked list
  [Fact]
  public void EmptyList()
  {
    SinglyLinkedList sll = new SinglyLinkedList();

    Assert.Null(sll.head);

  }


  //Can properly insert into the linked list
  [Fact]
  public void InsertToHead_CanInsert()
  {
    SinglyLinkedList sll = new SinglyLinkedList();

    sll.InsertToHead(5);

    Assert.Equal( sll.head.data, 5);
  }




  //  The head property will properly point to the first node in the linked list
  [Fact]
  public void HeadProperty_PointsToFirstNode()
  {
    SinglyLinkedList sll = new SinglyLinkedList();
    sll.InsertToHead(1);
    sll.InsertToHead(3);
    sll.InsertToHead(6);

    Assert.Equal(sll.head.data, 6);

  }

  //Can properly insert multiple nodes into the linked list
  //Can properly return a collection of all the values that exist in the linked list

  [Fact]
  public void InsertToHead_InsertMultipleNodes()
  {
    // Arrange
    SinglyLinkedList sll = new SinglyLinkedList();

    // Act
    sll.InsertToHead(2);
    sll.InsertToHead(4);
    sll.InsertToHead(8);

    // Assert
    Assert.Equal("{ 8 } -> { 4 } -> { 2 } -> NULL", sll.ToString());
  }




  //Will return true when finding a value within the linked list that exists
 
  [Fact]
  public void Includes_ReturnTrueIfExists()
  {
    // Arrange
    SinglyLinkedList sll = new SinglyLinkedList();

    // Act
    sll.InsertToHead(2);
    sll.InsertToHead(4);
    sll.InsertToHead(8);

    // Assert
    Assert.Equal(sll.Includes(4), true);
  }


  //Will return false when searching for a value in the linked list that does not exist

  [Fact]
  public void Includes_ReturnFalseIfNotExists()
  {

    // Arrange
    SinglyLinkedList sll = new SinglyLinkedList();

    // Act
    sll.InsertToHead(2);
    sll.InsertToHead(4);
    sll.InsertToHead(8);

    // Assert
    Assert.Equal(sll.Includes(6), false);

  }



 
  







  }

