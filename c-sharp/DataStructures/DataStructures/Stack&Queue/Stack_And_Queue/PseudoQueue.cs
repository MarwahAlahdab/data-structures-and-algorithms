using System;
namespace Stack_And_Queue
{
  public class PseudoQueue <T>
  {

    private Stack_And_Queue.Stack<T> stack1;
    private Stack_And_Queue.Stack<T> stack2;



    public PseudoQueue()
    {
      stack1 = new Stack<T>();
      stack2 = new Stack<T>();
    }


    /*
    Methods:
enqueue
Arguments: value
Inserts a value into the PseudoQueue, using a first-in, first-out approach.
dequeue
Arguments: none
Extracts a value from the PseudoQueue, using a first-in, first-out approach.



    */
    public bool IsEmpty()
    {
      return stack1.IsEmpty() && stack2.IsEmpty();
    }

    public void Enqueue(T value)
    {
      stack1.Push(value);

    }

    public T Dequeue()
    {
      if (IsEmpty())
      {
        throw new InvalidOperationException("PseudoQueue is empty!");
      }


      if (stack2.IsEmpty())
      {
        // Transfer elements from inbox to outbox in reverse order
        while (!stack1.IsEmpty())
        {
          stack2.Push(stack1.Pop());
        }
      }

      return stack2.Pop();




    }







  }
}

