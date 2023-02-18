using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class LargestNumber
    {

        public void findLargest()
        {
            Console.WriteLine("Enter three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if(a >= b && a >=c)
            {
                Console.WriteLine("{0} is the largest number", a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("{0} is the largest number", b);
            }
            else if (c >= b && c >= a)
            {
                Console.WriteLine("{0} is the largest number", c);
            }



        }
    }
}
