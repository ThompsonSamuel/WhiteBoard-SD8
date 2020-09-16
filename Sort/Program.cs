using System;
using System.Linq;

namespace Sort
{
    class Program
    {
        public static int[] Sort(int[] nums) => nums.OrderBy(x=>x).ToArray();

        static void Main(string[] args)
        {
            int[] numbers = SortBucketOfInts(GetBucketOfInts());
            Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static Random r = new Random();

        static int[] GetBucketOfInts( int size = 100 )
        {
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = r.Next(100);
            }
            return numbers;
        }

        static int[] SortBucketOfInts(int[] bucket)
        {
            int i;

            for (int a = 0; a <= bucket.Length - 2; a++)
            {
                for (int j = 0; j <= bucket.Length - 2; j++)
                {
                    if (bucket[j] > bucket[j + 1])
                    {
                        i = bucket[j + 1];
                        bucket[j + 1] = bucket[j];
                        bucket[j] = i;
                    }
                }
            }
            return bucket;
        }
    }
}
