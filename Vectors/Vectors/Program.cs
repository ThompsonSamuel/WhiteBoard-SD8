using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Two demensional closest point {GetClosest(GetPoints(), Get2Distance)}");
            Console.WriteLine($"Three demensional closest point {GetClosest(Get3Points(), Get3Distance)}");
        }

        static Random random = new Random(123);
        struct pointStruct
        {
            public int x;
            public int y;
            public int z;
        }
        //get random set of x, y points
        static List<pointStruct> GetPoints(int n = 100)   
        {
            List<pointStruct> points = new List<pointStruct>();
            for (int i = 0; i < n; i++)
                points.Add(new pointStruct { x = random.Next(100), y = random.Next(100) });
            return points;
        }
        static List<pointStruct> Get3Points(int n = 1000)   
        {
            List<pointStruct> points = new List<pointStruct>();
            for (int i = 0; i < n; i++)
                points.Add(new pointStruct { x = random.Next(1000), y = random.Next(1000), z = random.Next(1000) });
            return points;
        }
        //iterate through to find the distances
        static double GetClosest(List<pointStruct> points,  Distance distance)
        {
            double closest = distance(points.First(), points.LastOrDefault());
            foreach (pointStruct a in points)
            {
                foreach (pointStruct b in points)
                {
                    closest = (a.Equals(b)) ? closest : (distance(a, b) < closest && distance(a,b) != 1) ? closest = distance(a, b) : closest; //would return 1 from close numbers without != 1 statement
                }
            }
            return closest;
        }
        delegate double Distance(pointStruct pointA, pointStruct pointB);
        static double Get2Distance(pointStruct pointA, pointStruct pointB) => (double)Math.Sqrt(Math.Pow(pointA.x - pointB.x, 2) + Math.Pow(pointA.y - pointB.y, 2));  
        static double Get3Distance(pointStruct pointA, pointStruct pointB) => (double)Math.Sqrt(Math.Pow(pointA.x - pointB.x, 2) + Math.Pow(pointA.y - pointB.y, 2) + Math.Pow(pointA.z - pointB.z, 2));
    }
}
