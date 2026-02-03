namespace Lab1;

public class BinarySearchTreeNode<T> : IBinarySearchTree<T>
{

    private BinarySearchTreeNode<T>? Root {get;set;}

    public bool IsEmpty => Root == null;

    public int Count {get; private set;}

    public int Height => throw new NotImplementedException();


    public void Add(int key, T value)
    {
        if(IsEmpty)
        {
            Root = new BinarySearchTreeNode<T>(key, value);
            Count++;
        }
        else
        {
            AddRecursive(key, value, Root);
        }
    }

    private void AddRecursive(int key, T value, BinarySearchTreeNode<T> parent)
    {
        // existing key => update the value
        if( key == parent.Key)
        {
            parent.Value = value;
            return;
        }
        
        if( key < parent.Key)
        {
            // look left
            if (parent.Left == null)
            {
                var newNode = new BinarySearchTreeNode<T>(key, value);
                parent.Left = newNode;
                newNode.Parent = parent;
                Count++;
            }
            else
            {
                AddRecursive(key, value, parent.Left);
            }
        } 
        else
        {
            // look right 
            if( parent.Right == null )
            {
                var newNode = new BinarySearchTreeNode<T>(key, value);
                parent.Right = newNode;
                newNode.Parent = parent;
                Count++;
            }
            else
            {
                AddRecursive(key,value, parent.Right);
            }   
        }
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(int key)
    {
        throw new NotImplementedException();
    }

    public void Remove(int key)
    {
        throw new NotImplementedException();
    }

    public T Search(int key)
    {
        throw new NotImplementedException();
    }

    public void Update(int key, T value)
    {
        throw new NotImplementedException();
    }


    // Advanced 

     public BinarySearchTreeNode<T> MaxNode(BinarySearchTreeNode<T> node)
    {
        throw new NotImplementedException();
    }

    public BinarySearchTreeNode<T> MinNode(BinarySearchTreeNode<T> node)
    {
        throw new NotImplementedException();
    }

    public BinarySearchTreeNode<T> Next(BinarySearchTreeNode<T> node)
    {
        throw new NotImplementedException();
    }

    public BinarySearchTreeNode<T> Prev(BinarySearchTreeNode<T> node)
    {
        throw new NotImplementedException();
    }

    public List<BinarySearchTreeNode<T>> RangeSearch(int min, int max)
    {
        throw new NotImplementedException();
    }

     public int? MinKey => throw new NotImplementedException();

    public int? MaxKey => throw new NotImplementedException();

    public Tuple<int, T>? Min => throw new NotImplementedException();

    public Tuple<int, T>? Max => throw new NotImplementedException();

    public double MedianKey => throw new NotImplementedException();

    public List<int> InOrderKeys => throw new NotImplementedException();

    public List<int> PreOrderKeys => throw new NotImplementedException();

    public List<int> PostOrderKeys => throw new NotImplementedException();

}