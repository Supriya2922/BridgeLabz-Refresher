using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class SecondLargestElement
    {
        public void findSecondLargest()
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
            Array.Reverse(arr);
            if(arr.Length==1) {
                Console.WriteLine("Array contains only one element");
            
            }
            else
            {
                Console.WriteLine("The second largest element in an array is :" + arr[1]);
            }
            
        }
    }
}
