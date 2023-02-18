
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class LeapYear
    {
        public void checkLeapYear()
        {
            Console.WriteLine("Enter the year");
            int year=Convert.ToInt32(Console.ReadLine());
            if (year.ToString().Length != 4)
            {
                Console.WriteLine("The length of the year is not 4.Please enter a valid year");
                return;
            }
            else
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    Console.WriteLine("{0} is a leap year", year);
                else
                    Console.WriteLine("{0} is not a leap year", year);
            }
        }
    }
}
