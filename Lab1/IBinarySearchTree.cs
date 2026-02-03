namespace Lab1;

/// <summary>
/// A generic Binary Search Tree that stores key-value pairs, where keys are integers.
/// </summary>
/// <typeparam name="T">The type of values stored in the tree.</typeparam>
public interface IBinarySearchTree<T>
{
    /// <summary>
    /// Adds a new key-value pair to the tree. If the key already exists, updates its value.
    /// </summary>
    /// <param name="key">The key to add.</param>
    /// <param name="value">The value associated with the key.</param>
    public void Add(int key, T value);

    /// <summary>
    /// Determines whether the tree contains a node with the specified key.
    /// </summary>
    /// <param name="key">The key to search for.</param>
    /// <returns>True if the key exists in the tree; otherwise, false.</returns>
    public bool Contains(int key);

    /// <summary>
    /// Removes the node with the specified key from the tree.
    /// </summary>
    /// <param name="key">The key of the node to remove.</param>
    /// <exception cref="KeyNotFoundException">Thrown when the key does not exist in the tree.</exception>
    public void Remove(int key);

    /// <summary>
    /// Updates the value associated with an existing key. If the key does not exist, adds it.
    /// </summary>
    /// <param name="key">The key to update.</param>
    /// <param name="value">The new value to associate with the key.</param>
    public void Update(int key, T value);

    /// <summary>
    /// Retrieves the value associated with the specified key.
    /// </summary>
    /// <param name="key">The key to search for.</param>
    /// <returns>The value associated with the key.</returns>
    /// <exception cref="KeyNotFoundException">Thrown when the key does not exist in the tree.</exception>
    public T Search(int key);

    /// <summary>
    /// Removes all nodes from the tree.
    /// </summary>
    public void Clear();

    /// <summary>
    /// Gets a value indicating whether the tree is empty.
    /// </summary>
    public bool IsEmpty { get; }

    /// <summary>
    /// Gets the number of nodes in the tree.
    /// </summary>
    public int Count { get; }

    /// <summary>
    /// Gets the height of the tree (the number of edges on the longest path from root to leaf).
    /// Returns 0 for an empty tree or a tree with only the root node.
    /// </summary>
    public int Height { get; }

    // Advanced

    /// <summary>
    /// Gets the smallest key in the tree, or null if the tree is empty.
    /// </summary>
    public int? MinKey { get; }

    /// <summary>
    /// Gets the largest key in the tree, or null if the tree is empty.
    /// </summary>
    public int? MaxKey { get; }

    /// <summary>
    /// Gets the key-value pair with the smallest key, or null if the tree is empty.
    /// </summary>
    public Tuple<int, T>? Min { get; }

    /// <summary>
    /// Gets the key-value pair with the largest key, or null if the tree is empty.
    /// </summary>
    public Tuple<int, T>? Max { get; }

    /// <summary>
    /// Finds the node with the minimum key in the subtree rooted at the given node.
    /// </summary>
    /// <param name="node">The root of the subtree to search.</param>
    /// <returns>The node with the minimum key in the subtree.</returns>
    public BinarySearchTreeNode<T> MinNode(BinarySearchTreeNode<T> node);

    /// <summary>
    /// Finds the node with the maximum key in the subtree rooted at the given node.
    /// </summary>
    /// <param name="node">The root of the subtree to search.</param>
    /// <returns>The node with the maximum key in the subtree.</returns>
    public BinarySearchTreeNode<T> MaxNode(BinarySearchTreeNode<T> node);

    /// <summary>
    /// Gets the median key value. For an odd number of nodes, returns the middle key.
    /// For an even number of nodes, returns the average of the two middle keys.
    /// </summary>
    public double MedianKey { get; }

    /// <summary>
    /// Finds the in-order successor of the given node (the node with the next largest key).
    /// </summary>
    /// <param name="node">The node to find the successor for.</param>
    /// <returns>The successor node, or null if the given node has the largest key.</returns>
    public BinarySearchTreeNode<T> Next(BinarySearchTreeNode<T> node);

    /// <summary>
    /// Finds the in-order predecessor of the given node (the node with the next smallest key).
    /// </summary>
    /// <param name="node">The node to find the predecessor for.</param>
    /// <returns>The predecessor node, or null if the given node has the smallest key.</returns>
    public BinarySearchTreeNode<T> Prev(BinarySearchTreeNode<T> node);

    /// <summary>
    /// Returns all nodes with keys in the specified range (inclusive).
    /// </summary>
    /// <param name="min">The minimum key value (inclusive).</param>
    /// <param name="max">The maximum key value (inclusive).</param>
    /// <returns>A list of nodes with keys between min and max.</returns>
    public List<BinarySearchTreeNode<T>> RangeSearch(int min, int max);

    // Tree Traversal

    /// <summary>
    /// Gets all keys in in-order sequence (Left, Root, Right).
    /// Results are sorted in ascending order.
    /// </summary>
    public List<int> InOrderKeys { get; }

    /// <summary>
    /// Gets all keys in pre-order sequence (Root, Left, Right).
    /// </summary>
    public List<int> PreOrderKeys { get; }

    /// <summary>
    /// Gets all keys in post-order sequence (Left, Right, Root).
    /// </summary>
    public List<int> PostOrderKeys { get; }
}
