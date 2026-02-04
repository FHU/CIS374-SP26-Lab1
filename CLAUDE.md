# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build and Test Commands

```bash
# Build the solution
dotnet build

# Run all tests
dotnet test

# Run tests with verbose output
dotnet test --logger "console;verbosity=detailed"

# Run a specific test class
dotnet test --filter "FullyQualifiedName~BasicTests"
dotnet test --filter "FullyQualifiedName~AdvancedTests"

# Run a single test by name
dotnet test --filter "Name=Add"

# Run the main program
dotnet run --project Lab1
```

## Architecture

This is a .NET 9.0 C# project implementing a generic Binary Search Tree data structure with MSTest-based unit tests.

### Projects

- **Lab1/** - Main library containing the BST implementation
- **Lab1.Tests/** - MSTest 4.0 test suite

### Core Classes

- `IBinarySearchTree<T>` - Interface defining all required BST operations
- `BinarySearchTree<T>` - Main implementation class in `BinarySearchTree.cs`
- `BinarySearchTreeNode<T>` - Node class with Key (int), Value (T), Left, Right, and Parent pointers


### Implementation Status

The following are already implemented in `BinarySearchTree.cs`:

- `Add()` - Recursive insertion with parent pointer maintenance
- `Count`, `IsEmpty` properties

Methods stubbed with `NotImplementedException` that need implementation:

- `Height` property
- `GetNode()`, `Clear()`, `Contains()`, `Remove()`, `Search()`, `Update()`
- `MinKey`, `MaxKey`, `Min`, `Max` properties
- `MedianKey` property
- `MinNode()`, `MaxNode()` methods
- `Next()`, `Prev()` - in-order successor/predecessor
- `RangeSearch()` - range query
- `InOrderKeys`, `PreOrderKeys`, `PostOrderKeys` traversals

### Test Organization

- **BasicTests.cs** - Tests for Add(), Remove(), Height, Parent, Clear(), Update(), traversals, Contains(), Count, Search(), GetNode()
- **AdvancedTests.cs** - Tests for MinKey/MaxKey, MedianKey, Next/Prev, RangeSearch
