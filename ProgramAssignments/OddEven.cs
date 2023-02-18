using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class OddEven
    {
        public void findOddEven()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToByte(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} number is even.", num);
            }
            else
            {
                Console.WriteLine("{0} number is odd.", num);
            }
        }
    }
}
