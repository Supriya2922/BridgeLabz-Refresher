using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class SmallestGap
    {
        public void findGap()
        {
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0} :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(arr);
            
            int miniGap=int.MaxValue;
          
            for(int i = 0; i < n - 1; i++)
            {
                int gap = arr[i+1] - arr[i];
                miniGap= Math.Min(miniGap, gap);
            }
            Console.WriteLine("Smallest gap is :"+ miniGap);

        }
    }
}
