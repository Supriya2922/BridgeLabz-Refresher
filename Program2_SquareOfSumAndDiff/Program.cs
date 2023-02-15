// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace Program2_SquareOfSumAndDiff;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two decimal number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double sum=num1+ num2;
        
        double difference=num1- num2;
        double sqSum=Math.Pow(sum, 2);
       
        double sqDiff=Math.Pow(difference, 2);
        Console.Write("Square of the sum of two numbers :");
        Console.WriteLine(sqSum);
        Console.Write("Square of the Difference of two numbers :");
        Console.WriteLine(sqDiff);
        
    }
}
