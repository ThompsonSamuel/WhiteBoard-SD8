using System;

namespace Geometry
{
    public class Triangle
    {
        public static double areaOfTriangle(double tBase, double theight) => (tBase * theight) / 2.0;
        public static double hypoteneuse(double sideA, double sideB) => Math.Sqrt(sideA * sideA + sideB * sideB);
    }
}
