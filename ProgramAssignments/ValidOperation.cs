using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class ValidOperation
    {
        public void checkValidity(String str)
        {
            Regex pattern = new Regex(@"([0-9][\+,-,/,\*]{1}[0-9]$)+");
            
            Match match= pattern.Match(str);
            if(match.Success)
            {
                Console.WriteLine("Valid Expression");
                DataTable table= new DataTable();
                double res = (int)table.Compute(str, "");
                Console.WriteLine("The result of evaluating the expression is :"+res);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        
            
    }
}
