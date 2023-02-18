using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class Swap
    {
        public void swap()
        {
            Console.WriteLine("Enter two numbers");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers before swapping\n num1={0} \n num2={1} ", num1, num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Numbers after swapping\n num1={0} \n num2={1} ", num1, num2);
        }
    }
}
