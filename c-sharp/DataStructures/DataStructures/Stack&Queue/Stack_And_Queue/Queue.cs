using System;
namespace Stack_And_Queue
{

  public class Queue<T>
    {
      private Node<T> front;
      private Node<T> rear;

      public bool IsEmpty()
      {
        return front == null;
      }

      public void Enqueue(T data)
      {
        Node<T> newNode = new Node<T>(data);

        if (IsEmpty())
        {
          front = newNode;
          rear = newNode;
        }
        else
        {
          rear.Next = newNode;
          rear = newNode;
        }
      }

      public T Dequeue()
      {
        if (IsEmpty())
        {
          throw new InvalidOperationException("Queue is empty.");
        }

        T data = front.Data;
        front = front.Next;

        if (front == null)
        {
          rear = null;
        }

        return data;
      }

      public T Peek()
      {
        if (IsEmpty())
        {
          throw new InvalidOperationException("Queue is empty.");
        }

        return front.Data;
      }
    }

  }




