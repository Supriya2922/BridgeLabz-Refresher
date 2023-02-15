using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_5Progs
{
    public class Factorial
    {
       public long factorial(int n)
        {
            if (n >= 1)
                return n * factorial(n - 1);
            else
                return 1;
        }
    }
}
