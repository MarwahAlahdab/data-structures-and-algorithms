using System;
using System.Diagnostics.Metrics;
using System.Dynamic;
using Newtonsoft.Json.Linq;
using Stack_And_Queue;
using Stack_And_Queue.CC12;
using static System.Net.Mime.MediaTypeNames;

namespace StackQueueTests;

public class UnitTest1
{
    [Fact]
  public void Test1()
  {
  }




  //  Can successfully push onto a stack
  //Can successfully push multiple values onto a stack


  [Fact]
    public void Push_Successfully()
    {
    // Arrange
    Stack_And_Queue.Stack<int> stack = new Stack_And_Queue.Stack<int>();

      // Act
      stack.Push(10);
      stack.Push(20);

      // Assert
      //Assert.False(stack.IsEmpty());
      Assert.Equal(20, stack.Peek());
    }



  //Can successfully pop off the stack


  [Fact]
    public void Pop_Successfully()
    {
     Stack_And_Queue.Stack<int> stack = new Stack_And_Queue.Stack<int>();
      stack.Push(10);
      stack.Push(20);

      int poppedElement = stack.Pop();

      Assert.Equal(20, poppedElement);
      Assert.Equal(10, stack.Peek());
    }



  //Can successfully empty a stack after multiple pops

  [Fact]
    public void EmptyStack_AfterMultiplePops()
  {
    Stack_And_Queue.Stack<int> stack = new Stack_And_Queue.Stack<int>();
    stack.Push(10);
    stack.Push(20);

    stack.Pop();
    stack.Pop();

    Assert.True(stack.IsEmpty());
  }



  //Can successfully peek the next item on the stack ??

  [Fact]
  public void Peek_Successful()
  {
    Stack_And_Queue.Stack<string> stack = new Stack_And_Queue.Stack<string>();
    stack.Push("meme");
    stack.Push("lolo");

    string nextItem = stack.top.Next.Data;

    Assert.Equal("meme", nextItem);
  }





  //  Can successfully instantiate an empty stack

  [Fact]
  public void InstantiateEmptyStack_Successful()
  {

    Stack_And_Queue.Stack<int> stack = new Stack_And_Queue.Stack<int>();


    Assert.True(stack.IsEmpty());
  }



  //Calling pop or peek on empty stack raises exception

  [Fact]
  public void PopOnEmptyStack_RaisesException()
  {
 
    Stack_And_Queue.Stack<int> stack = new Stack_And_Queue.Stack<int>();

    
    Assert.Throws<InvalidOperationException>(() => stack.Pop());
  }



  [Fact]
  public void PeekOnEmptyStack_RaisesException()
  {
    
    Stack_And_Queue.Stack<int> stack = new Stack_And_Queue.Stack<int>();

    Assert.Throws<InvalidOperationException>(() => stack.Peek());
  }



  //Can successfully enqueue into a queue
  //Can successfully enqueue multiple values into a queue

  [Fact]
  public void Enqueue_Successfully()
  {
    Stack_And_Queue.Queue<int> queue = new Stack_And_Queue.Queue<int>();

    queue.Enqueue(10);
    queue.Enqueue(30);
    queue.Enqueue(40);


    Assert.Equal(10, queue.Peek());
  }







  //Can successfully dequeue out of a queue the expected value


  [Fact]
  public void Dequeue_Successfully()
  {

    Stack_And_Queue.Queue<int> queue = new Stack_And_Queue.Queue<int>();
    queue.Enqueue(10);
    queue.Enqueue(20);
    queue.Enqueue(30);

 
    int dequeuedValue = queue.Dequeue();

    Assert.Equal(10, dequeuedValue);
    Assert.Equal(20, queue.Peek());
  }


  //Can successfully peek into a queue, seeing the expected value


  [Fact]
  public void Peek_Successfully()
  {
    Stack_And_Queue.Queue<int> queue = new Stack_And_Queue.Queue<int>();
    queue.Enqueue(1);
    queue.Enqueue(2);

    
    int peekedValue = queue.Peek();

    Assert.Equal(1, peekedValue);
  }




  //Can successfully empty a queue after multiple dequeues

  [Fact]
  public void EmptyQueueAfterMultipleDequeues_Successful()
  {
 
    Stack_And_Queue.Queue<int> queue = new Stack_And_Queue.Queue<int>();
    queue.Enqueue(10);
    queue.Enqueue(20);
    queue.Enqueue(30);


    queue.Dequeue();
    queue.Dequeue();
    queue.Dequeue();

    Assert.True(queue.IsEmpty());
  }


  //  Can successfully instantiate an empty queue


  [Fact]
  public void InstantiateEmptyQueue_Successfully()
  {
    Stack_And_Queue.Queue<int> queue = new Stack_And_Queue.Queue<int>();

    Assert.True(queue.IsEmpty());
  }

  //Calling dequeue or peek on empty queue raises exception


  [Fact]
  public void Dequeue_OnEmptyQueue_RaisesException()
  {
    Stack_And_Queue.Queue<int> queue = new Stack_And_Queue.Queue<int>();

    Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
  }

  [Fact]
  public void Peek_OnEmptyQueue_RaisesException()
  {
    Stack_And_Queue.Queue<int> queue = new Stack_And_Queue.Queue<int>();

    
    Assert.Throws<InvalidOperationException>(() => queue.Peek());
  }







  // Pseudo Queue tests  CC-11


  [Fact]
  public void EnqueueAndDequeue_MultipleValues_Successfully()
  {
   
    PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

    pseudoQueue.Enqueue(10);
    pseudoQueue.Enqueue(20);
    pseudoQueue.Enqueue(30);
    int result1 = pseudoQueue.Dequeue();
    int result2 = pseudoQueue.Dequeue();
    int result3 = pseudoQueue.Dequeue();

    Assert.Equal(10, result1);
    Assert.Equal(20, result2);
    Assert.Equal(30, result3);
  }




  [Fact]
  public void Dequeue_EmptyQueue_ThrowsException()
  {
    // 
    PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();

    
    Assert.Throws<InvalidOperationException>(() => pseudoQueue.Dequeue());
  }





  // AnimalShelter CC-12

  [Fact]
  public void Enqueue_Enqueue_Success()
  {
    // Arrange
    var shelter = new AnimalShelter();
    var dog = new Animal("dog", "dog1");

    // Act
    shelter.Enqueue(dog);

    // Assert
    Assert.Equal(dog, shelter.dogs.Peek());
  }



  [Fact]
  public void Dequeue_PreferDog_ReturnsDog()
  {
    // Arrange
    var shelter = new AnimalShelter();
    var dog = new Animal("dog", "dog1");
    shelter.Enqueue(dog);

    var result = shelter.Dequeue("dog");

    Assert.Equal(dog, result);
  }



  [Fact]
  public void Dequeue_PreferUnknown_ReturnsOldestAnimal()
  {
    var shelter = new AnimalShelter();
    var dog = new Animal("dog", "dog1");
    var cat = new Animal("cat", "dog1");
    shelter.Enqueue(dog);
    shelter.Enqueue(cat);

    var result = shelter.Dequeue("unknown");

    Assert.Equal(dog, result);
  }

  




}


