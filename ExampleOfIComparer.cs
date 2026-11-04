using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    // Example for IComparer
    public class LocationPoint : IComparer<LocationPoint>
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        /// Compare two LocationPoint objects.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(LocationPoint? x, LocationPoint? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            // Compare based on X first, then Y if X values are equal
            int xComparison = x.X.CompareTo(y.X);
            if (xComparison != 0)
            {
                return xComparison;
            }

            return x.Y.CompareTo(y.Y);
        }
    }


    public class ExampleOfIComparer
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Comparer");

            // Create two LocationPoint objects
            LocationPoint point1 = new LocationPoint { X = 5, Y = 10 };
            LocationPoint point2 = new LocationPoint { X = 5, Y = 15 };

            // Create an instance of the comparer
            LocationPoint comparer = new LocationPoint();

            // Compare when both points are equal
            int result1 = comparer.Compare(point1, point1);
            Console.WriteLine($"Comparison of point1 with itself: {result1} (Expected: 0)");

            // Compare when point1 < point2
            int result2 = comparer.Compare(point1, point2);
            Console.WriteLine($"Comparison of point1 with point2: {result2} (Expected: -1)");

            // Compare when point1 > point2
            int result3 = comparer.Compare(point2, point1);
            Console.WriteLine($"Comparison of point2 with point1: {result3} (Expected: 1)");

            // Compare when one point is null
            int result4 = comparer.Compare(point1, null);
            Console.WriteLine($"Comparison of point1 with null: {result4} (Expected: 1)");

            int result5 = comparer.Compare(null, point2);
            Console.WriteLine($"Comparison of null with point2: {result5} (Expected: -1)");

            // Compare when both points are null
            int result6 = comparer.Compare(null, null);
            Console.WriteLine($"Comparison of null with null: {result6} (Expected: 0)");
        }
    }
}
