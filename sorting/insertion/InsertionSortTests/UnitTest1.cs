using System;
using InsertionSort;

namespace InsertionSortTests;

public class UnitTest1
{
  [Fact]
  public void TestInsertionSort()
  {
    // Arrange
    int[] unsortedArray = { 8, 4, 23, 42, 16, 15 };
    int[] expectedSortedArray = { 4, 8, 15, 16, 23, 42 };

    // Act
    Program.InsertionSort(unsortedArray);

    // Assert
    Assert.Equal(expectedSortedArray, unsortedArray);
  }
}


