using Stack_And_Queue;
using Stack_And_Queue.CC12;

internal class Program
{
  private static void Main(string[] args)
  {

    //Stack implementation
    Stack_And_Queue.Stack<int> stack = new Stack_And_Queue.Stack<int>();

    stack.Push(10);
    stack.Push(20);
    stack.Push(30);

    int top1 = stack.Peek();
    Console.WriteLine("Top: " + top1);
    int popped = stack.Pop();
    Console.WriteLine("Popped element: " + popped);

    int top2 = stack.Peek();
    Console.WriteLine("Top: " + top2);




    // Queue implementation
    Stack_And_Queue.Queue<string> queue = new Stack_And_Queue.Queue<string>();

    queue.Enqueue("Marwa");
    queue.Enqueue("Anas");
    queue.Enqueue("Tasneem");

    string front = queue.Peek();
    Console.WriteLine("Front element of queue: " + front);

    string dequeued = queue.Dequeue();
    Console.WriteLine("Dequeued element from queue: " + dequeued);

    string front2 = queue.Peek();
    Console.WriteLine("Front element of queue: " + front2);






    // CC 11

    PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

    // Enqueue some elements
    pseudoQueue.Enqueue(10);
    pseudoQueue.Enqueue(15);
    pseudoQueue.Enqueue(20);
    pseudoQueue.Enqueue(5);




    try
    {
      Console.WriteLine(pseudoQueue.Dequeue());
      Console.WriteLine(pseudoQueue.Dequeue());
      Console.WriteLine(pseudoQueue.Dequeue());
      Console.WriteLine(pseudoQueue.Dequeue());
      Console.WriteLine(pseudoQueue.Dequeue()); // Throws InvalidOperationException
    }
    catch (InvalidOperationException ex)
    {
      Console.WriteLine(ex.Message);
    }



  }
}