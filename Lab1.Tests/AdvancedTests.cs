namespace Lab1.Tests;
using Lab1;

[TestClass]
public class AdvancedTests
{

    [TestMethod]
    public void MinKey1()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 10);
        tree.Add(5, 5);
        tree.Add(20, 10);
        tree.Add(15, 10);
        tree.Add(25, 10);
        tree.Add(1, 10);
        tree.Add(12, 10);

        Assert.AreEqual(1, tree.MinKey);
    }

    [TestMethod]
    public void MinKey2()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 10);
        tree.Add(5, 5);
        tree.Add(20, 10);
        tree.Add(15, 10);
        tree.Add(25, 10);
        tree.Add(12, 10);

        Assert.AreEqual(5, tree.MinKey);
    }

    [TestMethod]
    public void MinKey3()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 10);
        tree.Add(20, 10);
        tree.Add(15, 10);
        tree.Add(25, 10);
        tree.Add(12, 10);

        Assert.AreEqual(10, tree.MinKey);
    }

    [TestMethod]
    public void MinKeyEmptyTree()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        Assert.IsNull(tree.MinKey);
    }

    [TestMethod]
    public void MaxKeyEmptyTree()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        Assert.IsNull(tree.MaxKey);
    }

    [TestMethod]
    public void Min()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 100);
        tree.Add(5, 50);
        tree.Add(20, 200);
        tree.Add(1, 10);

        var min = tree.Min;
        Assert.IsNotNull(min);
        Assert.AreEqual(1, min.Item1);
        Assert.AreEqual(10, min.Item2);
    }

    [TestMethod]
    public void MinEmptyTree()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        Assert.IsNull(tree.Min);
    }

    [TestMethod]
    public void Max()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 100);
        tree.Add(5, 50);
        tree.Add(20, 200);
        tree.Add(25, 250);

        var max = tree.Max;
        Assert.IsNotNull(max);
        Assert.AreEqual(25, max.Item1);
        Assert.AreEqual(250, max.Item2);
    }

    [TestMethod]
    public void MaxEmptyTree()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        Assert.IsNull(tree.Max);
    }

    [TestMethod]
    public void MinNode()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 100);
        tree.Add(5, 50);
        tree.Add(20, 200);
        tree.Add(3, 30);
        tree.Add(7, 70);
        tree.Add(15, 150);
        tree.Add(25, 250);

        // MinNode of entire tree (from root)
        var minNode = tree.MinNode(tree.GetNode(10));
        Assert.AreEqual(3, minNode.Key);

        // MinNode of right subtree
        var minRightSubtree = tree.MinNode(tree.GetNode(20));
        Assert.AreEqual(15, minRightSubtree.Key);
    }

    [TestMethod]
    public void MaxNode()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 100);
        tree.Add(5, 50);
        tree.Add(20, 200);
        tree.Add(3, 30);
        tree.Add(7, 70);
        tree.Add(15, 150);
        tree.Add(25, 250);

        // MaxNode of entire tree (from root)
        var maxNode = tree.MaxNode(tree.GetNode(10));
        Assert.AreEqual(25, maxNode.Key);

        // MaxNode of left subtree
        var maxLeftSubtree = tree.MaxNode(tree.GetNode(5));
        Assert.AreEqual(7, maxLeftSubtree.Key);
    }

    [TestMethod]
    public void MedianKeyEmptyTree()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        Assert.ThrowsExactly<InvalidOperationException>(() => { var _ = tree.MedianKey; });
    }

    [TestMethod]
    public void MedianKey1()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        for (int i = 0; i < 51; i++)
        {
            tree.Add(i, i + 1);
        }
        Assert.AreEqual(25.0, tree.MedianKey);
    }

    [TestMethod]
    public void MedianKey2()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        for (int i = 0; i < 52; i++)
        {
            tree.Add(i, i + 1);
        }
        Assert.AreEqual(25.5, tree.MedianKey);
    }

    [TestMethod]
    public void MedianKey3()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(1, 3);
        Assert.AreEqual(1.0, tree.MedianKey);
    }

    [TestMethod]
    public void MedianKey4()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(1, 3);
        tree.Add(2, 4);
        Assert.AreEqual(1.5, tree.MedianKey);
    }

    [TestMethod]
    public void MedianKey5()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(1, 3);
        tree.Add(2, 3);
        tree.Add(3, 3);
        tree.Add(10, 3);
        tree.Add(30, 3);
        Assert.AreEqual(3.0, tree.MedianKey);
    }

    [TestMethod]
    public void MedianKey6()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(10, 3);
        tree.Add(30, 3);
        tree.Add(35, 3);
        tree.Add(1, 3);
        tree.Add(2, 3);
        tree.Add(3, 3);
        Assert.AreEqual(6.5, tree.MedianKey);
    }

    [TestMethod]
    public void MaxKey()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        for (int i = 0; i < 52; i++)
        {
            tree.Add(i, i + 1);
        }
        Assert.AreEqual(51, tree.MaxKey);
    }

    [TestMethod]
    public void MaxKey2()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(4, 3);
        tree.Add(2, 4);
        tree.Add(5, 7);
        tree.Add(7, 2);
        tree.Add(6, 4);
        tree.Add(3, 4);
        Assert.AreEqual(7, tree.MaxKey);
    }

    [TestMethod]
    public void Next1()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }

        BinarySearchTreeNode<int> current;
        for (int i = 0; i < 49; i++)
        {
            current = tree.GetNode(i);
            Assert.AreEqual(tree.Search(i + 1), tree.Next(current).Value);
        }
    }

    [TestMethod]
    public void Next2()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(5, 5);
        tree.Add(4, 5);
        Assert.AreEqual(tree.Search(5), tree.Next(tree.GetNode(4)).Value);
    }

    [TestMethod]
    public void Next3()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(4, 5);
        tree.Add(5, 5);
        Assert.AreEqual(tree.Search(5), tree.Next(tree.GetNode(4)).Value);
    }

    [TestMethod]
    public void Next4Edge()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(4, 5);
        tree.Add(5, 5);
        Assert.IsNull(tree.Next(tree.GetNode(5)));
    }

    [TestMethod]
    public void Prev1()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }

        BinarySearchTreeNode<int> current;
        for (int i = 1; i < 50; i++)
        {
            current = tree.GetNode(i);
            Assert.AreEqual(tree.Search(i - 1), tree.Prev(current).Value);
        }
    }

    [TestMethod]
    public void Prev2()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(4, 5);
        tree.Add(5, 5);
        Assert.AreEqual(tree.Search(4), tree.Prev(tree.GetNode(5)).Value);
    }

    [TestMethod]
    public void Prev3()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(5, 5);
        tree.Add(4, 5);
        Assert.AreEqual(tree.Search(4), tree.Prev(tree.GetNode(5)).Value);
    }

    [TestMethod]
    public void Prev4Edge()
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        tree.Add(4, 5);
        tree.Add(5, 5);
        Assert.IsNull(tree.Prev(tree.GetNode(4)));
    }

    [TestMethod]
    public void Range1()
    {
        int min = 3;
        int max = 40;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(38, range); // 40 - 3 + 1
        for (int i = min; i < (max + 1); i++)
        {
            Assert.Contains(tree.GetNode(i), range);
        }
    }

    [TestMethod]
    public void Range2()
    {
        int min = 0;
        int max = 49;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(50, range); // 49 - 0 + 1
        for (int i = min; i < (max + 1); i++)
        {
            Assert.Contains(tree.GetNode(i), range);
        }
    }

    [TestMethod]
    public void Range3()
    {
        int min = 48;
        int max = 49;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(2, range); // 49 - 48 + 1
        for (int i = min; i < (max + 1); i++)
        {
            Assert.Contains(tree.GetNode(i), range);
        }
    }

    [TestMethod]
    public void Range4()
    {
        int min = 49;
        int max = 49;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(1, range); // 49 - 49 + 1
        for (int i = min; i < (max + 1); i++)
        {
            Assert.Contains(tree.GetNode(i), range);
        }
    }

    [TestMethod]
    public void Range5()
    {
        int min = 0;
        int max = 0;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(1, range); // 0 - 0 + 1
        for (int i = min; i < (max + 1); i++)
        {
            Assert.Contains(tree.GetNode(i), range);
        }
    }

    [TestMethod]
    public void Range6()
    {
        int min = 23;
        int max = 33;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(11, range); // 33 - 23 + 1
        for (int i = min; i < (max + 1); i++)
        {
            Assert.Contains(tree.GetNode(i), range);
        }
    }

    [TestMethod]
    public void Range7()
    {
        int min = 7;
        int max = 37;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = (i + 13) % 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(31, range); // 37 - 7 + 1
        for (int i = min; i < (max + 1); i++)
        {
            Assert.Contains(tree.GetNode(i), range);
        }
    }

    [TestMethod]
    public void Range8Edge()
    {
        int min = -1;
        int max = 37;
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            index = i + 50;
            tree.Add(index, index);
        }
        List<BinarySearchTreeNode<int>> range = tree.RangeSearch(min, max);
        Assert.HasCount(0, range);
    }
}
