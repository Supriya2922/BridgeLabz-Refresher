using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class RepeatedElement
    {
        public void FirstRepeatElement()
        {
            HashSet<int> set = new HashSet<int>();
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int elem = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (set.Contains(arr[i]))
                {
                    elem = arr[i];
                    break;
                }
                else
                {
                    set.Add(arr[i]);
                }
            }
            if (elem == int.MinValue)
                Console.WriteLine("No repeating elements");
            else
                Console.WriteLine("First repeating element is:" + elem);
        }
    }
}
