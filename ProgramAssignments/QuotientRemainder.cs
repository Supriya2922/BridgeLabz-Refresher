using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class QuotientRemainder
    {
        public void findQuotientReminder()
        {
            Console.WriteLine("Enter the value of dividend");
            int dividend=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor");
            int divisor=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient :" + (dividend / divisor));
            Console.WriteLine("Remainder :" + (dividend % divisor));
        }
    }
}
