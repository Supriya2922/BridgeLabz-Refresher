using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class VowelOrConstant
    {
        public void findVowelOrConstant()
        {
            Console.WriteLine("Enter an aplhabet");
            char ch=Convert.ToChar(Console.Read());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine("{0} is a vowel ", ch);
            else
                Console.WriteLine("{0} is a consonant ", ch);

        }
    }
}
