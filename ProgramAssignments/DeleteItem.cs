using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class DeleteItem
    {
        public void deleteElem()
        {
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0} :",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter the position of the element to be deleted:");
            int index = Convert.ToInt32(Console.ReadLine());
            for(int i = index - 1; i < n-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine("Array after deleting the element at position {0}", index);
            for(int i = 0; i < n - 1; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
