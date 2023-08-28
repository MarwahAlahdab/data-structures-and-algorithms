using System;
using System.Globalization;
using System.Security.Cryptography;

namespace InsertionSort;

public class Program
{
    static void Main(string[] args)
    {



    int[] inputArray = { 8, 4, 23, 42, 16, 15 };
    InsertionSort(inputArray);

    Console.WriteLine("Sorted Array:");
    foreach (int num in inputArray)
    {
      Console.Write(num + " ");
    }




  }


  //solution 1

  //static void Insert(int[] sorted, int value)
  //{
  //  int i = 0;
  //  while (i < sorted.Length && value > sorted[i])
  //  {
  //    i++;
  //  }
  //  while (i < sorted.Length)
  //  {
  //    int temp = sorted[i];
  //    sorted[i] = value;
  //    value = temp;
  //    i++;
  //  }
  //}



  //static int[] InsertionSort(int[] input)
  //  {
  //    int[] sorted = new int[input.Length];
  //    sorted[0] = input[0];

  //    for (int i = 1; i < input.Length; i++)
  //    {
  //      Insert(sorted, input[i]);
  //    }

  //    return sorted;
  //  }

  //solution 2


  public static void InsertionSort(int[] arr)
  {
    for (int i = 1; i < arr.Length; i++)
    {
      int key = arr[i];
      int j = i - 1;

      while (j >= 0 && arr[j] > key)
      {
        arr[j + 1] = arr[j];
        j--;
      }

      arr[j + 1] = key;
    }
  }










}

