using System;
using System.Globalization;
using System.Security.Cryptography;

namespace MergeSort;



  public class Program
{


  public static void Main(string[] args)
  {
  
  }




  public static void MergeSortAlgorithm(int[] arr, int left, int right) // left and right are index not values , if the array size is 5 , the left =0 and right = 5
  {
    if (left < right)
    {
      int middle = (left + right) / 2;

      MergeSortAlgorithm(arr, left, middle);
      MergeSortAlgorithm(arr, middle + 1, right);

      Merge(arr, left, middle, right);
    }
  }



  public static void Merge(int[] arr, int left, int middle, int right)
  {
    int n1 = middle - left + 1;
    int n2 = right - middle;

    int[] leftArr = new int[n1];
    int[] rightArr = new int[n2];

    for (int i = 0; i < n1; i++)
      leftArr[i] = arr[left + i];
    for (int j = 0; j < n2; j++)
      rightArr[j] = arr[middle + 1 + j];

    int k = left;
    int p = 0, q = 0;

    while (p < n1 && q < n2)
    {
      if (leftArr[p] <= rightArr[q])
      {
        arr[k] = leftArr[p];
        p++;
      }
      else
      {
        arr[k] = rightArr[q];
        q++;
      }
      k++;
    }

    while (p < n1)
    {
      arr[k] = leftArr[p];
      p++;
      k++;
    }

    while (q < n2)
    {
      arr[k] = rightArr[q];
      q++;
      k++;
    }
  }











}

