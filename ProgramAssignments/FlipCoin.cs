using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    internal class FlipCoin
    {
        public void percentageHeadsTails()
        {
            int head=0,tail=0;
            double headpercent = 0, tailpercent = 0;
            Console.WriteLine("Enter the number of times to flip a coin:");
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Random rand=new Random();
                var coin = rand.NextDouble();
                if (coin < 0.5)
                    tail += 1;
                else
                    head += 1;

            }
            headpercent = (head / (double)n) * 100.0;
            tailpercent = (tail / (double)n) * 100.0;
            Console.WriteLine("Head percentage :" + headpercent+"%");
            Console.WriteLine("Tail percentage :" + tailpercent + "%");
        }
    }
}
