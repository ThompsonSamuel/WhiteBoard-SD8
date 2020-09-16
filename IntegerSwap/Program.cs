using System;

namespace IntegerSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            IntSwap();
        }
        static void IntSwap()
        {
            int x = 5;
            int y = 17;

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"x = {x} y = {y}");
        }
    }
}
