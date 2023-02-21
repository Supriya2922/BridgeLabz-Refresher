using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Gambler
    {
        public static void gamblerfunc()
        {
            int win = 0, loose = 0;
            Console.WriteLine("Enter the stack($stack)");
            int stack=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the goal($goal)");
            int goal=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the total number of times:");
            int n=Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (stack > 0 && stack < goal)
                {
                    Random rand = new Random();
                    double gamble = rand.NextDouble();
                    if (gamble > 0.5)
                    {
                        win += 1;
                        stack += 1;
                        
                    }
                    else
                    {
                        loose += 1;
                        stack -= 1;
                        
                    }
                }
                else if(stack >= goal)
                {
                    Console.WriteLine("Congragulations! you have reached the Goal!");
                    break;
                }
                else
                {
                    Console.WriteLine("Stack is empty :(");
                    break;
                }

                i++;
            }
            Console.WriteLine("Total number of wins :" + win);
            Console.WriteLine("Win percentage:" + (win * 100.0) / n+"%");
            Console.WriteLine("Lost percentage:" + (loose * 100.0) / n+"%");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
