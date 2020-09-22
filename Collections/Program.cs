using System;
using System.Linq;

namespace TestScores
{
    class Collections
    {
        static void Main(string[] args)
        {
            int[] tests = GetScores(100);
            foreach(int i in SortedScores(tests))
                Console.WriteLine(i);
        }
        static Random random = new Random();
        static int[] GetScores(int n)
        {
            int[] tests = new int[n];
            for(int i = 0; i < n; i++)
            {
                tests[i] = random.Next(1,101);
            }
            return tests;
        }
        static double CalcValue(int[] tests)
        {
            int total = 0;
            foreach(int i in tests)
            {
                total += i;
            }
            return total / tests.Length;
        }
        static int HigheScore(int[] tests)
        {
            int highest = tests[0];
            foreach (int i in tests)
                highest = i > highest ? i : highest;
            return highest;
        }
        static int[] SortedScores(int[] tests)
        {
            for (int i = 0; i < tests.Length-1; i++)
            {
                for (int j = 0; j < tests.Length-1; j++)
                {
                    int temp = 0;
                    if (tests[j] > tests[j+1])
                    {
                        temp = tests[j];
                        tests[j] = tests[j + 1];
                        tests[j + 1] = temp;
                    }
                }
            }
            return tests;
        }
    }
}
