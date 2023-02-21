using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Functional_Programs
{
    internal class WindChill
    {
        public static void findWindChill()
        {
            Console.WriteLine(" Enter temperature t (in Fahrenheit) :");
            double t=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter wind speed v (in miles per hour):");
            double v=Convert.ToDouble(Console.ReadLine());
            double w = 0;
            if(Math.Abs(t)<=50 && v<=120 && v >= 3)
            {
                double a = (0.4275 * t) - 35.75;
                w = 35.74 + (0.6215 * t) + (a * Math.Pow(v, 0.16));
            }
            Console.WriteLine("Wind Chill ="+w);
        }
    }
}
