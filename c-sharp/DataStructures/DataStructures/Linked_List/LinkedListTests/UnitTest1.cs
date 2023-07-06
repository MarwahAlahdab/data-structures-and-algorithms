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





  //CC-07





  //  Where k is greater than the length of the linked list

  [Fact]
  public void KthFromEnd_WhenKGreaterThanLength_ReturnDefault()
  {
    // Arrange
    LinkedList list = new LinkedList();
    list.Append(1);
    list.Append(3);
    list.Append(8);
    list.Append(2);

  

    // Assert
    Assert.Throws<ArgumentException>(() => list.KthFromEnd(5));
  }





//Where k and the length of the list are the same

[Fact]
  public void KthFromEnd_KAndLengthAreSame_ReturnException()
  {
    // Arrange
    LinkedList list = new LinkedList();
    list.Append(1);
    list.Append(3);
    list.Append(8);
    list.Append(2);

    // Assert
    Assert.Throws<ArgumentException>(() => list.KthFromEnd(4));

  }








  //Where k is not a positive integer

  [Fact]
  public void KthFromEnd_KNegative_ReturnDefault()
  {
 
    LinkedList list = new LinkedList();
    list.Append(1);
    list.Append(3);
    list.Append(8);
    list.Append(2);


    int result = list.KthFromEnd(-2);

    Assert.Equal(default(int), result);
  }











  //Where the linked list is of a size 1

  [Fact]
  public void KthFromEnd_LinkedListSizeIsOne()
  {
  
    LinkedList list = new LinkedList();
    list.Append(5);


    int result = list.KthFromEnd(0);

    Assert.Equal(5, result);
  }




  //“Happy Path” where k is not at the end, but somewhere in the middle of the linked list

  [Fact]
  public void KthFromEnd_HappyPath()
  {

    LinkedList list = new LinkedList();
    list.Append(1);
    list.Append(3);
    list.Append(8);
    list.Append(2);


    int result = list.KthFromEnd(2);

    Assert.Equal(3, result);
  }









  //CC-07







  [Fact]
  public void ZipLists_EmptyLists_ReturnsEmptyList()
  {
    // Arrange
    LinkedList list1 = new LinkedList();
    LinkedList list2 = new LinkedList();

    // Act
    LinkedList zippedList = Program.ZipLists(list1, list2);

    // Assert
    Assert.Null(zippedList.head);
  }



  [Fact]
  public void ZipLists_TwoLists_ReturnsZippedList()
  {

    LinkedList list1 = new LinkedList();
    list1.Append(1);
    list1.Append(3);
    list1.Append(5);

  
    LinkedList list2 = new LinkedList();
    list2.Append(2);
    list2.Append(4);
    list2.Append(6);


    LinkedList zippedList = Program.ZipLists(list1, list2);

    // Assert
    Assert.Equal(1, zippedList.head.Data);
    Assert.Equal(2, zippedList.head.Next.Data);
    Assert.Equal(3, zippedList.head.Next.Next.Data);
    Assert.Equal(4, zippedList.head.Next.Next.Next.Data);
    Assert.Equal(5, zippedList.head.Next.Next.Next.Next.Data);
    Assert.Equal(6, zippedList.tail.Data);
    Assert.Null(zippedList.tail.Next);
  }



}



















