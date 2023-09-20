using System;
using System.Collections.Generic;
using HashTables; 

namespace HashTable.Trees
{



  public class TreeNode
  {
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
      Value = value;
      Left = null;
      Right = null;
    }
  }

  public class BinaryTree
  {
    public TreeNode Root { get; set; }

    public BinaryTree()
    {
      Root = null;
    }

    // Insert a value into the binary tree
    public void Insert(int value)
    {
      Root = InsertRecursive(Root, value);
    }

    private TreeNode InsertRecursive(TreeNode current, int value)
    {
      if (current == null)
      {
        return new TreeNode(value);
      }

      if (value < current.Value)
      {
        current.Left = InsertRecursive(current.Left, value);
      }
      else if (value > current.Value)
      {
        current.Right = InsertRecursive(current.Right, value);
      }

      return current;
    }
  }

  public static class TreeIntersection
  {
    public static HashSet<int> FindIntersection(BinaryTree tree1, BinaryTree tree2, HashMap hashMap)
    {
      HashSet<int> intersection = new HashSet<int>();
      CollectValues(tree1.Root, hashMap);
      FindIntersection(tree2.Root, hashMap, intersection);

      return intersection;
    }

    private static void CollectValues(TreeNode node, HashMap hashMap)
    {
      if (node == null)
      {
        return;
      }

      hashMap.Set(node.Value.ToString(), "present");
      CollectValues(node.Left, hashMap);
      CollectValues(node.Right, hashMap);
    }

    private static void FindIntersection(TreeNode node, HashMap hashMap, HashSet<int> intersection)
    {
      if (node == null)
      {
        return;
      }

      if (hashMap.Has(node.Value.ToString()))
      {
        intersection.Add(node.Value);
      }

      FindIntersection(node.Left, hashMap, intersection);
      FindIntersection(node.Right, hashMap, intersection);
    }
  }




}
