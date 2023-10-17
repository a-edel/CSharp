using System.Collections;

namespace MyApp
{ 
    internal class Program
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

    internal class GenericHeapSort<T> where T : IComparable<T>
    {
        public static void HeapSort(T[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                T temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);
            }

        }

        public static void Heapify(T[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l].CompareTo(arr[largest]) == 1)
                largest = l;

            if (r < n && arr[r].CompareTo(arr[largest]) == 1)
                largest = r;

            if (largest != i)
            {
                T swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }
    }
}