using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_5Progs
{
    public class PrintTill100
    {
        public void print(int n)
        {
            if (n > 100) return;
            Console.Write(n +" ");
            print(n + 1);
        }
    }
}
