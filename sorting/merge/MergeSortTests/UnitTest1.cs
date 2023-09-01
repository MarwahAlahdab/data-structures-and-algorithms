using System;
using MergeSort;
namespace MergeSortTests;

public class UnitTest1
{



  private bool IsSorted(int[] arr)
  {
    for (int i = 1; i < arr.Length; i++)
    {
      if (arr[i] < arr[i - 1])
      {
        return false;
      }
    }
    return true;
  }





  [Fact]
  public void MergeSort_SortsReverseSortedArray()
  {
    // Arrange
    int[] arr = { 20, 18, 12, 8, 5, -2 };
    int[] expected = { -2, 5, 8, 12, 18, 20 };

    // Act
    Program.MergeSortAlgorithm(arr, 0, arr.Length - 1);

    // Assert
    Assert.Equal(expected, arr);
  }



  [Fact]
  public void MergeSort_SortsFewUniquesArray()
  {
    int[] arr = { 5, 12, 7, 5, 5, 7 };
    int[] expected = { 5, 5, 5, 7, 7, 12 };

    Program.MergeSortAlgorithm(arr, 0, arr.Length - 1);

    Assert.Equal(expected, arr);
  }



  [Fact]
  public void MergeSort_SortsNearlySortedArray()
  {
    // Arrange
    int[] arr = { 2, 3, 5, 7, 13, 11 };
    int[] expected = { 2, 3, 5, 7, 11, 13 };

    Program.MergeSortAlgorithm(arr, 0, arr.Length - 1);

    Assert.Equal(expected, arr);
  }




}

