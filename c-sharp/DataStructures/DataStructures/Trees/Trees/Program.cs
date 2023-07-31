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




 
  }
}