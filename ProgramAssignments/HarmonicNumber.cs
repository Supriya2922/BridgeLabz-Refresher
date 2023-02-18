using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class HarmonicNumber
    {
        public void printHarmonicSum()
        {
            Console.WriteLine("Enter the number of terms(n):");
            int n=Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.Write("1/{0}+",i);
                sum += 1 / (float)i;

            }
            Console.WriteLine("\nSum of the series="+sum);
        }
    }
}
