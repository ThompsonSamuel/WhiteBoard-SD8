using System;

namespace TimeFunction
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(GetX());


        }
        public static int timeBetween(int hour1, int minute1, int hour2, int minute2)
        {


            int hourbetween = (hour2 % 12) - (hour1 % 12);
            int minutebetween = minute2 - minute1;
            return minutebetween + (hourbetween * 60);
        }
        static int GetX()
        {
            int x = 4;
            int y = 0;
            for (int i = 0; i < x; i++)
            {
                y += i;
            }
            x = y;

            return x;
        }
    }
}
