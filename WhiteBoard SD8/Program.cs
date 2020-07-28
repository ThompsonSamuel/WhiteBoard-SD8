using System;
using Geometry;


namespace WhiteboardSD8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WhiteboardSD8.prgogram.main()");

            double b = 3.0, h = 1.0;
            Console.WriteLine($"Area of a triangle with base:{b} and height:{h} = {Triangle.areaOfTriangle(b,h)}");
        }
    }
}