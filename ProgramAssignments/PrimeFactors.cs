using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class PrimeFactors
    {
        public void primeFactors()
        {
            Console.WriteLine("Enter the number to find prime factors:");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors are :");
            while(n %2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for(int i = 3; i <= Math.Sqrt(n); i+=2)
            { 
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
            {
                Console.Write(n);
            }

        }
    }
}
