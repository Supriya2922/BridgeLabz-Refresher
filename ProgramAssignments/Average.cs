using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class Average
    {
        public void findAverage()
        {
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            float[] arr = new float[n];
            float average = 0; float sum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToSingle(Console.ReadLine());
                sum += arr[i];
            }
            average = sum / n;
            Console.WriteLine("Average is:" + average);


        }
    }
}
