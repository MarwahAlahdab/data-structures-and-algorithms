using Trees;

namespace BinaryTreeTests;

public class UnitTest1
{
  //  Can successfully instantiate an empty tree

  [Fact]
  public void CanInstantiateEmptyTree_Successfully()
  {
    
    BinaryTree<int> bt = new BinaryTree<int>();

    Assert.Null(bt.Root);
  }




  //Can successfully instantiate a tree with a single root node

  [Fact]
  public void Add_CanInstantiateTreeWithSingleRootNode()
  {
    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    int rootValue = 10;
    bst.Add(rootValue);

    Assert.NotNull(bst.Root);
    Assert.Null(bst.Root.Left);
    Assert.Null(bst.Root.Right);
  }



  //For a Binary Search Tree, can successfully add a left child and right child properly to a node

  [Fact]
  public void Add_AddLeftAndRightChildToNodeProperly()
  {
    
    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    
    bst.Add(10);
    bst.Add(5);
    bst.Add(15);

    Assert.Equal(5, bst.Root.Left.Value);
    Assert.Equal(15, bst.Root.Right.Value);
  }


  //Can successfully return a collection from a pre-order traversal

  [Fact]
  public void PreOrderTraversal_ReturnCollectionSuccessfully()
  {
    
    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    bst.Add(5);
    bst.Add(3);
    bst.Add(7);
    bst.Add(2);
    bst.Add(4);
    bst.Add(6);
    bst.Add(8);

    int[] expected = { 5, 3, 2, 4, 7, 6, 8 };
    int[] result = bst.PreOrderTraversal();

    Assert.Equal(expected, result);
  }


  //Can successfully return a collection from an in-order traversal

  [Fact]
  public void InOrderTraversal_ReturnCollectionSuccessfully()
  {

    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    bst.Add(5);
    bst.Add(3);
    bst.Add(7);
    bst.Add(2);
    bst.Add(4);
    bst.Add(6);
    bst.Add(8);

    int[] expected = { 2, 3, 4, 5, 6, 7, 8 };
    int[] result = bst.InOrderTraversal();

    Assert.Equal(expected, result);
  }


  //Can successfully return a collection from a post-order traversal

  [Fact]
  public void PostOrderTraversal_ReturnCollectionSuccessfully()
  {
    
    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    bst.Add(5);
    bst.Add(3);
    bst.Add(7);
    bst.Add(2);
    bst.Add(4);
    bst.Add(6);
    bst.Add(8);

    int[] expected = { 2, 4, 3, 6, 8, 7, 5 };
    int[] result = bst.PostOrderTraversal();

    Assert.Equal(expected, result);
  }


  //Returns true	false for the contains method, given an existing or non-existing node value
  [Fact]
  public void Contains_ReturnsTrueForExistingNodeValue()
  {
    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    bst.Add(2);
    bst.Add(4);
    bst.Add(6);

    Assert.True(bst.Contains(4));
  }

  [Fact]
  public void Contains_ReturnsFalseForNonExistingNodeValue()
  {
    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    bst.Add(2);
    bst.Add(4);
    bst.Add(6);

    Assert.False(bst.Contains(3));
  }



  //cc16

  [Fact]
  public void FindMaxValue_EmptyTree_ThrowsException()
  {
    // 
    BinaryTree<int> binaryTree = new BinaryTree<int>();

    Assert.Throws<InvalidOperationException>(() => binaryTree.FindMaxValue());
  }

  

  [Fact]
  public void FindMaxValue_ReturnsMaxValue()
  {
    BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
    binarySearchTree.Add(10);
    binarySearchTree.Add(15);
    binarySearchTree.Add(5);
    binarySearchTree.Add(3);
    binarySearchTree.Add(8);

    int maxValue = binarySearchTree.FindMaxValue();

    Assert.Equal(15, maxValue);
  }





  //cc-17

  [Fact]
  public void BreadthFirstTraversal_NullTree_ReturnEmptyList()
  {
    BinaryTree<int> binaryTree = new BinaryTree<int>();

    List<int> result = binaryTree.BreadthFirstTraversal(binaryTree);

    Assert.Empty(result);
  }


  [Fact]
  public void BreadthFirstTraversal_ReturnCorrectOrder()
  {
    BinaryTree<int> binaryTree = new BinaryTree<int>();
    binaryTree.Root = new Node<int>(2);
    binaryTree.Root.Left = new Node<int>(7);
    binaryTree.Root.Right = new Node<int>(5);
    binaryTree.Root.Left.Left = new Node<int>(2);
    binaryTree.Root.Left.Right = new Node<int>(6);
    binaryTree.Root.Right.Right = new Node<int>(9);
    binaryTree.Root.Left.Right.Left = new Node<int>(5);
    binaryTree.Root.Left.Right.Right = new Node<int>(11);
    binaryTree.Root.Right.Right.Left = new Node<int>(4);

   
    List<int> result = binaryTree.BreadthFirstTraversal(binaryTree);

    int[] expectedOrder = new int[] { 2, 7, 5, 2, 6, 9, 5, 11, 4 };
    Assert.Equal(expectedOrder, result);
  }



}

