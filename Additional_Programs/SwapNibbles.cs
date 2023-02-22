using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Programs
{
    internal class SwapNibbles
    {
        public static bool isPowerOfTwo(int n)
        {
            if (n == 0) return false;
            while (n != 1)
            {
                if(n%2!=0)
                    return false;
                n /= 2;
            }
            return true;
        }
        public static void swap()
        {
            Console.WriteLine("Enter number:");
            int num=Convert.ToInt32(Console.ReadLine());    
            int r = (num & 0x0F) <<4;
            int l = (num & 0xF0) >> 4;
            int n = r | l;
            Console.WriteLine("The swapped bit number is:"+n);
            if (isPowerOfTwo(n))
                Console.WriteLine("{0} is a power of 2", n);
            else
                Console.WriteLine("{0} is not a power of 2", n);



        }
    }
}
