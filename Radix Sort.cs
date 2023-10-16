using System;
using System.Collections;

namespace MyApp
{     
    internal class CSharpRadixSort
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

            int[] newArr = RadixSort(arr);

            Console.WriteLine();
            foreach (int value in newArr)
                Console.WriteLine(value);
        }

        public static int[] RadixSort(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int numberOfDigits = 0;
            while (max != 0)
            {
                max /= 10;
                ++numberOfDigits;
            }
            for (int digit = 1; digit <= numberOfDigits; digit++)
            {                
                ArrayList[] buckets = new ArrayList[10];

                for (int i = 0; i < 10; i++)
                {
                    buckets[i] = new ArrayList();
                }

                int divisor = 1;
                for (int j = 0; j < digit; j++)
                    divisor *= 10;                  
                for (int i = 0; i < arr.Length; i++)
                {                    
                    int bucketIndex = arr[i] / divisor % 10;                    
                    buckets[bucketIndex].Add(arr[i]);
                }       
                int[] newArr = new int[10];
                int newArrIndex = 0;
                for (int bucket = 0; bucket < buckets.Length; bucket++)
                {
                    ArrayList currentBucket = buckets[bucket];
                    for (int i = 0; i < currentBucket.Count; i++)
                    {                    
                        newArr[newArrIndex++] = (int)currentBucket[i];                    
                    }
                }
                arr = newArr;
            }
            return arr;
        }
    }
}
