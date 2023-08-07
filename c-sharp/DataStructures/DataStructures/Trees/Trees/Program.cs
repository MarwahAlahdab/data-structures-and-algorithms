using Trees;

internal class Program
{
  private static void Main(string[] args)
  {

    BinarySearchTree<int> bst = new BinarySearchTree<int>();
    bst.Add(5);
    bst.Add(3);
    bst.Add(7);
    bst.Add(2);
    bst.Add(4);
    bst.Add(6);
    bst.Add(8);

    Console.WriteLine("Pre-order traversal: " + string.Join(", ", bst.PreOrderTraversal()));
    Console.WriteLine("In-order traversal: " + string.Join(", ", bst.InOrderTraversal()));
    Console.WriteLine("Post-order traversal: " + string.Join(", ", bst.PostOrderTraversal()));

    Console.WriteLine("Contains 4: " + bst.Contains(4)); // true
    Console.WriteLine("Contains 10: " + bst.Contains(10)); // false


    Console.WriteLine("-------------"); 

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

    List<int> values = binaryTree.BreadthFirstTraversal(binaryTree);
    string output = "[" + string.Join(",", values) + "]";

    Console.WriteLine(output);


    Console.WriteLine("-------------");


    BinarySearchTree<int> tree = new BinarySearchTree<int>();
    tree.Add(5);
    tree.Add(7);
    tree.Add(9);
    tree.Add(15);


    BinarySearchTree<string> fizzBuzzTree = tree.FizzBuzz(tree);

    List<string> fizzBuzzValues = fizzBuzzTree.BreadthFirstTraversal(fizzBuzzTree);
    Console.WriteLine("FizzBuzz Tree values:");
    foreach (string value in fizzBuzzValues)
    {
      Console.WriteLine(value);
    }





  }
}