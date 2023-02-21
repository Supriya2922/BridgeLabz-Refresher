using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    internal class EucledianDistance
    {
        public static void findEucledianDistance()
        {
            //sqrt(x * x + y * y)
            Console.WriteLine("Enter x coordinate");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate");
            double y = Convert.ToDouble(Console.ReadLine());
            double dist = Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y, 2));
            Console.WriteLine($"Euclidean distance from the point ({x},{y}) to the origin (0, 0) is {dist}");
        }
    }
}
