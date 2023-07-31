# Trees

This Console App project provides a simple implementation of a Binary Tree and a Binary Search Tree.

## Features

- Create a Binary Tree.
- Perform depth-first traversals(Pre-Order, In-Order, and Post-Order)  on the Binary Tree.
- Create a Binary Search Tree as a subclass of the Binary Tree.
- In BinarySearchTree class, You can Add nodes to the Binary Search Tree in the correct location based on node values.
- Check if a value exists in the Binary Search Tree.



# Challenge Title
Trees implementation
Add a method to Find the Maximum Value in a Binary Tree


## Whiteboard Process
![](./cc16.jpeg)

## Approach & Efficiency
In this project, I implemented a BinaryTree<<T>T> class, which represents a generic binary tree, and a BinarySearchTree<<T>T> class, which is a sub-class of BinaryTree<T> and represents a binary search tree.
The BinaryTree<T> class contains methods for depth-first traversals (pre-order, in-order, and post-order) to return arrays of values ordered appropriately.

Also, I added a method FindMaxValue to the BinaryTree<T> class to find the maximum value in the binary tree.

For the implementation of the FindMaxValue method, I used a recursive depth-first traversal approach starting from the root node. The method recursively explores the left and right subtrees to find the maximum value.


FindMaxValue: O(n) - The time complexity as it traverses all nodes once to find the maximum value.

## Solution

To use the binary tree and binary search tree classes, follow these steps:

- Include the BinaryTree<T> and BinarySearchTree<T> classes in your project.
-
Example
Here's an example of how to use the binary search tree to find the maximum value:



class Program
{
    static void Main()
    {
        // Create a binary search tree and add nodes
        BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
        binarySearchTree.Add(10);
        binarySearchTree.Add(5);
        binarySearchTree.Add(15);
        binarySearchTree.Add(3);
        binarySearchTree.Add(8);
        binarySearchTree.Add(20);

        int maxValue = binarySearchTree.FindMaxValue();
        Console.WriteLine("Maximum value in the binary tree: " + maxValue);
    }
}
Output:

Maximum value in the binary tree: 20
