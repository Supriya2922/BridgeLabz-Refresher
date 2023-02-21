using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programs
{
    internal class TargetSumZero
    {
        public static void targetSumZero()
        {
            Console.WriteLine("Enter the total number of numbers of the array:");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[n];
            Console.WriteLine("Enter the values");
            for(int i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());    
            }
            bool found = false;
            for(int i=0;i<n-2; i++)
            {
                for(int j=i+1;j<n-1;j++)
                {
                    for(int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            found = true;
                            Console.WriteLine($"Triplet found ! \n{arr[i]} ,{arr[j]} ,{arr[k]} ");
                        }
                            
                    }
                }
            }
            if(found==false)
            {
                Console.WriteLine("Triplet not found");
            }
        }
    }
}
