using System.Collections;
using System.Xml.Linq;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
            }
            foreach (int i in arr)
                Console.WriteLine(i);
            Console.WriteLine();

            GenericHeapSort<int>.HeapSort(arr);
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }

    class GenericHeapSort<T> where T : IComparable<T>
    {
        public static void HeapSort(T[] arr) 
        {
            BinaryTree<T> tree = new BinaryTree<T>();
            tree.Insert(arr);
            tree.Heapify();  
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                tree.Swap();
                tree.Heapify();          
            }
            T[] sortedArray = tree.ConvertTreeToArray(); tree.ConvertTreeToArray();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                arr[i] = sortedArray[i];
            }
        }        
    }
}

public class Node<T>
{
    public T Data;
    public Node<T> Left, Right;

    public Node(T item)
    {
        Data = item;
        Left = Right = null;
    }
}

public class BinaryTree<T> where T : IComparable<T>
{
    public Node<T> root;

    public void Insert(T[] arr)
    {
        root = InsertRecursive(arr, 0);
    }

    private Node<T> InsertRecursive(T[] arr, int index)
    {
        if (index < arr.Length)
        {
            Node<T> temp = new Node<T>(arr[index]);
            temp.Left = InsertRecursive(arr, 2 * index + 1);
            temp.Right = InsertRecursive(arr, 2 * index + 2);
            return temp;
        }
        return null;
    }

    public void Heapify()
    {
        HeapifyRecursive(root);
    }

    private void HeapifyRecursive(Node<T> node)
    {
        if (node == null)
            return;

        Node<T> largest = node;
        Node<T> left = node.Left;
        Node<T> right = node.Right;

        if (left != null && left.Data.CompareTo(largest.Data) > 0)
            largest = left;

        if (right != null && right.Data.CompareTo(largest.Data) > 0)
            largest = right;

        if (!largest.Equals(node))
        {
            // Swap data
            T temp = node.Data;
            node.Data = largest.Data;
            largest.Data = temp;

            // Recur for the sub-tree
            HeapifyRecursive(largest);
        }
        HeapifyRecursive(node.Left);
        HeapifyRecursive(node.Right);
    }

    public void Swap()
    {
        Node<T> lastNode = FindLastNode(root);
        T temp = root.Data;
        root.Data = lastNode.Data;
        lastNode.Data = temp;
    }

    private Node<T> FindLastNode(Node<T> node)
    {
        if (node == null)
            return null;

        Node<T> temp = node;
        while (temp.Right != null)
        {
            temp = temp.Right;
        }

        return temp;
    }

    public void InOrderTraversal(Node<T> node, List<T> result)
    {
        if (node == null) return;

        InOrderTraversal(node.Left, result);
        result.Add(node.Data);
        InOrderTraversal(node.Right, result);
    }

    public T[] ConvertTreeToArray()
    {
        List<T> elements = new List<T>();
        InOrderTraversal(root, elements);
        return elements.ToArray();
    }
}


    