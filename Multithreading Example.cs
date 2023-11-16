namespace Multithreading_Example
{
    public class MultithreadingExample
    {
        public static void Main()
        {
            const int NUM_THREADS = 10;

            Random random = new Random();
            int[] arr = new int[1_000_000];


            for (int i = 0; i < 1_000_000; i++)
            {
                arr[i] = random.Next(1, 101);
            }

            Console.WriteLine(MultithreadingArraySum(arr, NUM_THREADS));
        }

        public static long MultithreadingArraySum(int[] arr, int threads)
        {
            // Initialize the shared sum variable
            MyThread.GrandSum = 0;

            // Convert the input array to a List for easier sub-list creation
            List<int> listToArrayList = new List<int>(arr);
            Thread[] threadArray = new Thread[threads];

            // Create and start threads for parallel computation
            for (int i = 0; i < threads; i++)
            {
                int start = arr.Length / threads * i;
                int end = (i == threads - 1) ? arr.Length : arr.Length / threads * (i + 1);
                List<int> subList = listToArrayList.GetRange(start, end - start);

                // Create a thread with the ThreadStart delegate
                Thread t = new Thread(new ThreadStart(new MyThread(subList).Run));
                t.Start();
                threadArray[i] = t;
            }

            // Wait for all threads to finish using Join
            foreach (Thread t in threadArray)
            {
                t.Join();
            }

            // Return the final sum
            return MyThread.GrandSum;
        }

        // Class representing a thread that computes the sum of a sub-list
        internal class MyThread
        {
            private List<int> subList;
            private int sum;
            public static long GrandSum;

            // Constructor to initialize the thread with a sub-list
            public MyThread(List<int> subList)
            {
                this.subList = subList;
            }

            // Method executed by the thread
            public void Run()
            {
                // Compute the sum of the sub-list
                foreach (int i in subList)
                {
                    sum += i;
                }

                // Synchronize access to the shared GrandSum variable using a lock
                lock (typeof(MyThread))
                {
                    GrandSum += sum;
                }
            }
        }
    }    
}

