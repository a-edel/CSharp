namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
            }

            foreach (int value in arr)
                Console.WriteLine(value);

            int[] newArr = SortAlgorithms.ShellSort(arr);

            Console.WriteLine();
            foreach (int value in newArr)
                Console.WriteLine(value);
        }
    }

    public class SortAlgorithms
    {
        public static T[] ShellSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i += 1)
                {
                    T temp = array[i];
                    int j;
                    for (j = i; j >= interval && array[j - interval].CompareTo(temp) > 0; j -= interval)
                    {
                        array[j] = array[j - interval];
                    }
                    array[j] = temp;
                }
            }
            return array;
        }
    }
}