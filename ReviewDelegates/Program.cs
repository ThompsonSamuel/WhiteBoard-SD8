using System;
using System.Drawing;

namespace ReviewDelegates {
    class GetDistanceDelegate {
        public delegate double Distance(Point A, Point B);
        event Distance GotDistance;

        public void OnGetDistance(Point a, Point b) {
            if (GotDistance != null) 
                getDistance(a,b);
        }
        public double getDistance(Point A, Point B) {
            return (double)Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
    }

    class GetDistinceFunc {
        public event Func<Point, Point, double> Distance;

        public void OnGetDistance(Point a, Point b) {
            if (Distance != null) {
                getDistance(a, b);
            }
        }
        public double getDistance(Point A, Point B) {
            return (double)Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
    }
}
