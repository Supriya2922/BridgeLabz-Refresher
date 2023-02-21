using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
     public class IOLibrary
    {
        public static int[,] readInt2DArray()
        {
            Console.WriteLine("Enter row length");
            
            int r= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column length");
            int c= Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[r,c];
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        public static double[,] readDouble2DArray()
        {
            Console.WriteLine("Enter row length");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column length");
            int c = Convert.ToInt32(Console.ReadLine());
            double[,] arr = new double[r, c];
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return arr;
        }
        public static bool[,] readBoolean2DArray()
        {
            Console.WriteLine("Enter row length");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column length");
            int c = Convert.ToInt32(Console.ReadLine());
            bool[,] arr = new bool[r, c];
            Console.WriteLine("Enter the values");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = Convert.ToBoolean(Console.ReadLine());
                }
            }
            return arr;
        }
        public static int[,] printInt2DArray(int[,] arr)
        {
            int r =arr.GetLength(0);
            int c = arr.GetLength(1);
            
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            return arr;
        }
        public static double[,] printDouble2DArray(double[,] arr)
        {
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            return arr;
        }
        public static bool[,] printBoolean2DArray(bool[,] arr)
        {
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            return arr;
        }

    }
}
