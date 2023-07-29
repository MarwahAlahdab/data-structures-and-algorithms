using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Trees;

namespace Trees
{
  public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
  {
    //No constructor , just to make it sorted

    public void Add (T value)
    {
      Root = AddNode(Root, value);
    }




    public Node<T> AddNode(Node<T> node,T value)
    {

      if (node == null)
        return new Node<T>(value);


      if (value.CompareTo(node.Value) > 0) //returns positave when its greater
        node.Right = AddNode(node.Right, value);

      else if (value.CompareTo(node.Value) < 0)
        node.Left = AddNode(node.Left, value);

      return node;

    }



    /*

Contains
Argument: value
Returns: boolean indicating whether or not the value is in the tree at least once.
*/



    public bool Contains(T value)
    {
      return Contains(Root, value);
    }

    private bool Contains(Node<T> node, T value)   //recursion
    {
      if (node == null)
      {
        return false;
      }

      if (node.Value.Equals(value))
      {
        return true;
      }
      else if (value.CompareTo(node.Value) < 0)
      {
        return Contains(node.Left, value);
      }
      else 
      {
        return Contains(node.Right, value);
      }
    }


  }
}


