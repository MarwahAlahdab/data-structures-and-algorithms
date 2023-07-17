using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using static Program;

public class Program
{
  private static void Main(string[] args)
  {
    //LinkedList list1 = new LinkedList();

    //list1.Append(1);
    //list1.Append(3);
    //list1.Append(8);
    //list1.Append(2);

    //try
    //{
    //  //list1.InsertBefore(30, 3);
    //  //list1.InsertAfter(30, 40);
    //  int kthValue = list1.KthFromEnd(2);
    //  Console.WriteLine("Kth Value: " + kthValue);
     
    //}
    //catch (ArgumentException ex)
    //{
    //  Console.WriteLine(ex.Message );
    //}


    //Console.WriteLine(list1.PrintList());


    LinkedList list1 = new LinkedList();
    list1.Append(1);
    list1.Append(3);
    list1.Append(5);

    LinkedList list2 = new LinkedList();
    list2.Append(2);
    list2.Append(4);
    list2.Append(6);


    Console.WriteLine(list1.PrintList());
    Console.WriteLine(list2.PrintList());
    LinkedList zippedList = ZipLists(list1, list2);
    Console.WriteLine(zippedList.PrintList());

    LinkedList list3 = new LinkedList();

     list1.ReverseLinkedList();
    Console.WriteLine(list1.PrintList());


    LinkedList list = new LinkedList();
    list.Append(1);
    list.Append(2);
    list.Append(3);
    list.Append(5);
    list.Append(1);

    bool isPalindrome = list.Palindrome();

    Console.WriteLine("Is Palindrome: " + isPalindrome);



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
    public Node tail;


    public LinkedList(){

      head = null;
      tail = null;
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
        tail = newNode;
        return;
      }
       

      if(head.Next == null)
      {
        head.Next = newNode;
        tail = newNode;
        return;
      }

      Node current = head;

      while(current.Next != null)
      {
        current = current.Next;

      }

      current.Next = newNode;
      tail = newNode;
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

      if (current == tail) // Update tail if inserting after the last node
      {
        tail = newNode;
      }
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






    //k-th value from the end of a linked list.
    //Return the node’s value that is k places from the tail of the linked list.
    //public void kthFromEnd(int k)
    //{
    //  // 1 -> 2 -> 4 -> 6



    //}



    public int KthFromEnd(int k)
    {
      if (k <= 0 )
      {
        return default(int);//0
      }

      if (IsEmpty())
      {
        throw new InvalidOperationException("Linked list is empty.");
      }

      Node current = head;
      int length = 0;

      // Calculate the length of the linked list
      while (current != null)
      {
        length++;
        current = current.Next;
      }

      if (k >= length)
      {
        throw new ArgumentException("Invalid input!");
      }

      current = head;
      int position = length - k - 1;
      // -1 : zero based

      for (int i = 0; i < position; i++)
      {
        current = current.Next;
      }

      return current.Data;
    }






    public void ReverseLinkedList()
    {
      Node prev = null;
      Node current = head;
      Node next = null;

      while (current != null)
      {
        next = current.Next;
        current.Next = prev;
        prev = current;
        current = next;
      }

      tail = head;
      head = prev;
    }



    public bool Palindrome()
    {
      if (IsEmpty() || head.Next == null)
      {
        // If empty or single element then its palindrome
        return true;
      }

      // Find the middle node 
      Node slow = head;
      Node fast = head;
      Node prev = null;

      while (fast != null && fast.Next != null)
      {
        fast = fast.Next.Next;

       
        Node nextNode = slow.Next;
        slow.Next = prev;  // this will Reverse the first half
        prev = slow;
        slow = nextNode;
      }

      // If the fast is not null -> list has an odd number of elements
      // move slow to skip the middle 
      if (fast != null)
      {
        slow = slow.Next;
      }

      // Compare the two halfs
      while (slow != null)
      {
        if (slow.Data != prev.Data)
        {
          return false;
        }
        slow = slow.Next;
        prev = prev.Next;
      }

      return true;
    }

    //How it works (split the list & compare): 1 -> 2 -> 3 -> 3 -> 2 -> 1     (even length)
    //list1: 1 <- 2 <- 3
    //list2: 3 -> 2 -> 1






  }



  //    Return: New Linked List, zipped as noted below
  //Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the the zipped list.
  //Try and keep additional space down to O(1)


  public static LinkedList ZipLists(LinkedList l1, LinkedList l2)
  {
    LinkedList l3 = new LinkedList();

    Node current1 = l1.head;
    Node current2 = l2.head;



    while (current1 != null || current2 != null)
    {
      if (current1 != null)
      {
        l3.Append(current1.Data);
        current1 = current1.Next;
      }

      if (current2 != null)
      {
        l3.Append(current2.Data);
        current2 = current2.Next;
      }



    }



    return l3;

  }






}