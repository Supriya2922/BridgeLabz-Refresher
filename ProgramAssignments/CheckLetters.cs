using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class CheckLetters
    {
        public void Check(String str)
        {
            if (str.Contains('a') && str.Contains('e') && str.Contains('p'))
            {
                Console.WriteLine("All present");
            }
            else if (str.Contains('a') || str.Contains('e') || str.Contains('p'))
            {
                Console.WriteLine("One or more present");
            }
            else
            {
                Console.WriteLine("None present");
            }
        }
    }
}
