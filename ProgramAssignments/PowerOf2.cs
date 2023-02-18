using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class PowerOf2
    {
        public void printPower()
        {
            Console.WriteLine("Enter the value of n");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n\t\t 2 to power of n");
            for(int i=0; i<=n && n<31; i++) {
                Console.WriteLine($"{i}\t\t{Math.Pow(2, i)}");
            }
        }
    }
}
