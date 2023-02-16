using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class NumberToString
    {
        public void checkFactors(int n)
        {
            String s = "";
            if (n % 3 == 0)
                s += "Pling";
            if (n % 5 == 0)
                s += "Plang";
            if (n % 7 == 0)
                s += "Plong";
            if (n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
                s += n;
            Console.WriteLine(s);
        }
    }
}
