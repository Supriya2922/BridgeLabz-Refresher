using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class QuadraticEqn
    {
        public void findRoots(int a, int b, int c)
        {
            double root1, root2;
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("It has two complex roots");
            }
            else if (discriminant == 0)
            {
                root1 = -b / (2.0 * a);
                root2 = root1;
                Console.WriteLine("Both roots are equal!");
                Console.WriteLine("Root 1:" + root1);
                Console.WriteLine("Root 2:" + root2);

            }
            else
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);
                Console.WriteLine("Both roots are real and unequal!");
                Console.WriteLine("Root 1:" + root1);
                Console.WriteLine("Root 2:" + root2);
            }
        }
    }
}
