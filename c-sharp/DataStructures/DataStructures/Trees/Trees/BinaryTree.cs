using System;
namespace Trees
{
  public class BinaryTree<T>
  {

    public Node <T> Root { get; set; }

    public BinaryTree()
    {
      Root = null;
    }

    public T[] PreOrderTraversal() //root -> left -> right
    {
      List<T> result = new List<T>();
      PreOrderTraversal(Root, result);
      return result.ToArray();
      //Each depth first traversal method should return an array of values, ordered appropriately.
    }


    private void PreOrderTraversal(Node<T> node, List <T> result) //root -> left -> right
    {
      //recursion
      if(node != null)
      {
        result.Add(node.Value);
        PreOrderTraversal(node.Left, result);
        PreOrderTraversal(node.Right, result);


      }

    }

    public T[] InOrderTraversal()
    {
      List<T> result = new List<T>();
      InOrderTraversal(Root, result);
      return result.ToArray();
    }




    private void InOrderTraversal(Node<T> node, List<T> result) //left -> root -> right
    {
      //recursion
      if (node != null)
      {

        InOrderTraversal(node.Left, result);
        result.Add(node.Value);
        InOrderTraversal(node.Right, result);


      }

    }


    public T[] PostOrderTraversal()
    {
      List<T> result = new List<T>();
      PostOrderTraversal(Root, result);
      return result.ToArray();
    }

    private void PostOrderTraversal(Node<T> node, List<T> result) //left -> right -> root
    {
      if (node != null)
      {
        PostOrderTraversal(node.Left, result);
        PostOrderTraversal(node.Right, result);
        result.Add(node.Value);
      }
    }

    /*
     * find maximum value
Arguments: none
Returns: number
Find the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.
    */




    public int FindMaxValue()
    {
      if (Root == null)
        throw new InvalidOperationException("Tree is empty");

      return FindMaxValueRecursive(Root);
    }



    private int FindMaxValueRecursive(Node<T> node)
    {
      int max = Convert.ToInt32(node.Value);

      if (node.Left != null)
      {
        int leftMax = FindMaxValueRecursive(node.Left);
        max = Math.Max(max, leftMax);
      }

      if (node.Right != null)
      {
        int rightMax = FindMaxValueRecursive(node.Right);
        max = Math.Max(max, rightMax);
      }

      return max;
    }



  }
}
