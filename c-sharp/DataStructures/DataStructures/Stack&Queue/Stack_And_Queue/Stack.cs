using System;
namespace Stack_And_Queue
{



    public class Node<T>
    {
      public T Data { get; set; }
      public Node<T> Next { get; set; }

      public Node(T data)
      {
        Data = data;
        Next = null;
      }
    }

    public class Stack<T>
    {
      public Node<T> top;

    public bool IsEmpty()
    {
      return top == null;
    }

    public void Push(T data)
      {
        Node<T> newNode = new Node<T>(data);

        if (IsEmpty())
        {
          top = newNode;
        }
        else
        {
          newNode.Next = top;
          top = newNode;
        }
      }

      public T Pop()
      {
        if (IsEmpty())
        {
          throw new InvalidOperationException("Stack is empty.");
        }

        T data = top.Data;
        top = top.Next;
        return data;
      }

      public T Peek()
      {
        if (IsEmpty())
        {
          throw new InvalidOperationException("Stack is empty.");
        }

        return top.Data;
      }

   
  }




  }




