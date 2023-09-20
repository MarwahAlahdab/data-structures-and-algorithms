using System;
using HashTable.Trees;
using HashTables;

namespace HashTableTests
{
  public class TreeIntersectionTests
  {
    [Fact]
    public void TestTreeIntersection()
    {
      var tree1 = new BinaryTree();
      var tree2 = new BinaryTree();

      tree1.Insert(1);
      tree1.Insert(2);
      tree1.Insert(3);
      tree1.Insert(4);
      tree1.Insert(5);

      tree2.Insert(3);
      tree2.Insert(4);
      tree2.Insert(5);
      tree2.Insert(6);
      tree2.Insert(7);

      var hashMap = new HashMap(100);

      var intersection = TreeIntersection.FindIntersection(tree1, tree2, hashMap);

      // intersection contains the common values (3, 4, 5)
      Assert.True(intersection.Contains(3));
      Assert.True(intersection.Contains(4));
      Assert.True(intersection.Contains(5));

      // intersection does not contain values that are not common
      Assert.False(intersection.Contains(1));
      Assert.False(intersection.Contains(2));
      Assert.False(intersection.Contains(6));
      Assert.False(intersection.Contains(7));
    }
  }
}

