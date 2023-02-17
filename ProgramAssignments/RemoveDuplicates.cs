using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAssignments
{
    public class RemoveDuplicates
    {
        public void remove()
        {
            Console.WriteLine("Enter the length of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            String[] arr = new String[n];
            HashSet<String> set = new HashSet<String>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0} :", i + 1);
                arr[i] =Console.ReadLine();
                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }
            Console.WriteLine("After removing Duplicates :");
            foreach(var item in set)
                {
                Console.WriteLine(item);
                }
        }
    }
}
