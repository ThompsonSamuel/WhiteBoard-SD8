using System;

namespace LargerInt
{
    public class Program
    {
        public static string intCompare(int A, int B)
        {
            if (A > B)
                return $"{A} > {B}";
            else
                return $"{B} > {A}";
        }
        static void Main(string[] args)
        {
            int A = 5;
            int B = 9;
            Console.WriteLine(intCompare(A,B));
        }
    }
}
