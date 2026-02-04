# Lab 1: Binary Search Tree Implementation

A .NET 9.0 C# project for implementing a generic Binary Search Tree (BST) data structure.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

## Getting Started

```bash
# Build the solution
dotnet build

# Run all tests
dotnet test

# Run tests with verbose output
dotnet test --logger "console;verbosity=detailed"
```

## Project Structure

```
Lab1/
├── Lab1/                    # Main library
│   ├── BinarySearchTree.cs      # BST implementation (to be completed)
│   ├── BinarySearchTreeNode.cs  # Node class
│   └── IBinarySearchTree.cs     # Interface defining BST operations
└── Lab1.Tests/              # Unit tests
    ├── BasicTests.cs            # Core functionality tests
    └── AdvancedTests.cs         # Advanced operation tests
```

## Implementation Tasks

The `BinarySearchTree<T>` class has `Add()`, `Count`, and `IsEmpty` already implemented. You need to implement the remaining methods:

### Basic Operations

- `Height` - Number of edges on longest path from root to leaf
- `GetNode(int key)` - Returns the node with the given key
- `Search(int key)` - Returns the value associated with the key
- `Contains(int key)` - Returns true if key exists
- `Remove(int key)` - Removes the node with the given key
- `Update(int key, T value)` - Updates value for existing key or adds if not found
- `Clear()` - Removes all nodes

### Traversals

- `InOrderKeys` - Left, Root, Right (sorted order)
- `PreOrderKeys` - Root, Left, Right
- `PostOrderKeys` - Left, Right, Root

### Advanced Operations

- `MinKey`, `MaxKey` - Smallest/largest key in tree
- `Min`, `Max` - Key-value pair with smallest/largest key
- `MinNode(node)`, `MaxNode(node)` - Min/max node in subtree
- `MedianKey` - Middle key value (average of two middle keys if even count)
- `Next(node)` - In-order successor
- `Prev(node)` - In-order predecessor
- `RangeSearch(min, max)` - All nodes with keys in range (inclusive)

## Running Specific Tests

```bash
# Run basic tests only
dotnet test --filter "FullyQualifiedName~BasicTests"

# Run advanced tests only
dotnet test --filter "FullyQualifiedName~AdvancedTests"

# Run a single test by name
dotnet test --filter "Name=Add"
dotnet test --filter "Name=HeightInt"
```
