using Day2_5Progs;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("\n\nSelect an option:");
                Console.WriteLine("1.Factorial of a number");
                Console.WriteLine("2.Print 1 - 100 witout using loop");
                Console.WriteLine("3.Find roots of Quadratic equation");
                Console.WriteLine("4.Number to String based on factors");
                Console.WriteLine("5.Check presence of a, e, p");
                Console.WriteLine("6.Average of numbers(float array)");
                Console.WriteLine("7.Find Prime number");
                Console.WriteLine("8.Shift all zeros to end of the array");
                Console.WriteLine("9.Find the First repeated element in the array");
                Console.WriteLine("10.Valid arithmetic expression");
                Console.WriteLine("11.Length of Longest substring without repeating characters");
                Console.WriteLine("12.Exit");
                Console.WriteLine("Enter your choice:");

                int ch = Convert.ToInt32(Console.ReadLine());
            
                switch (ch)
                {
                    case 1:
                        Factorial obj1 = new Factorial();
                        Console.WriteLine("Enter a number:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        long ans = obj1.factorial(n);
                        Console.WriteLine("Factorial is :" + ans);
                        break;
                    case 2:
                        PrintTill100 obj2 = new PrintTill100();
                        Console.WriteLine("Numbers from 1-100 without using loop :");
                        obj2.print(1);
                        break;
                    case 3:
                        QuadraticEqn obj3 = new QuadraticEqn();
                        Console.WriteLine("Enter value of a :");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of b:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of c:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        obj3.findRoots(a, b, c);
                        break;
                    case 4:
                        NumberToString obj4 = new NumberToString();
                        Console.WriteLine("Enter number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The equivalent string is:");
                        obj4.checkFactors(num);
                        break;
                    case 5:
                        CheckLetters obj5 = new CheckLetters();
                        Console.WriteLine("Enter the string :");
                        String str = Console.ReadLine();
                        obj5.Check(str);
                        break;
                    case 6:
                        Average obj6=new Average();
                        obj6.findAverage();
                        break;
                    case 7:
                        PrimeNumber obj7= new PrimeNumber();
                        obj7.findPrime();
                        break;

                    case 11:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;



                }

            }
        }
    }
}