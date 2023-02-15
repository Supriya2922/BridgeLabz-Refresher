namespace Day2_5Progs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:\n1.Factorial of a number \n2.Print 1-100 witout using loop\n3.Find roots of Quadratic equation\n4.Number to String\n5.Check presence of a,e,p");
            int ch=Convert.ToInt32(Console.ReadLine()); 
            switch(ch)
            {
                case 1:
                    Factorial obj1= new Factorial();
                    Console.WriteLine("Enter a number:");
                    int n=Convert.ToInt32(Console.ReadLine());
                    long ans = obj1.factorial(n);
                    Console.WriteLine("Factorial is :"+ans);
                    break;
                case 2:
                    PrintTill100 obj2= new PrintTill100();
                    Console.WriteLine("Numbers from 1-100 without using loop :");
                    obj2.print(1);
                    break;

            }
        }
    }
}