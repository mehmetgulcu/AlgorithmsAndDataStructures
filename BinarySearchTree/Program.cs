class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value) => Value = value;
}

class BinarySearchTree
{
    public Node Root;

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, int value)
    {
        if (root == null) return new Node(value);

        if(value < root.Value) 
            root.Left = InsertRec(root.Left, value);
        else
            root.Right = InsertRec(root.Right, value);
        return root;
    }

    public void InOrder(Node node)
    {
        if(node == null) return;
        InOrder(node.Left);
        Console.WriteLine(node.Value);
        InOrder(node.Right);
    }
}

class Program
{
    static void Main()
    {
        var bst = new BinarySearchTree();
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);

        Console.WriteLine("InOrder Traversal:");
        bst.InOrder(bst.Root);
    }
}