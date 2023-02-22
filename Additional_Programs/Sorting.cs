using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Programs
{
    internal class Sorting
    {
        public static void sort()
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
            var sortlist = InsertionSort(arr);
            Console.WriteLine("Insertion Sort:");
            foreach (var item in sortlist)
            {
                Console.WriteLine(item);
            }
                    }
        private static IEnumerable<T> InsertionSort<T>(IEnumerable<T> list) where T : IComparable
        {
            T[] sortedList = list.ToArray();
            int listLength = sortedList.Length;
            for (int i = 1; i < listLength; i++)
            {
                for (int j = i - 1; j > -1; j--)
                {
                    int cur = j + 1;
                    T currentItem = sortedList[cur];
                    T previousItem = sortedList[j];
                    var comparison = previousItem.CompareTo(currentItem);
                    if (comparison > 0)
                    {
                        sortedList[j] = currentItem;
                        sortedList[cur] = previousItem;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return sortedList;
        }

        private static void PrintList<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
