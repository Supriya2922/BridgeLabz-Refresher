using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_5Progs
{
    public class PrimeNumber
    {
        public static bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        public void findPrime()
        {
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Prime numbers are :");
            for (int i = 0; i < n; i++)
            {
                if (isPrime(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
