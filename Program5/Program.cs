using System;
namespace Program5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        String name=Console.ReadLine();
        String[] parts = name.Split(" ");
        Console.WriteLine("Number of parts of name:"+ parts.Length);
        if(parts.Length == 2 ) { 
        Console.WriteLine("First name :" + parts[0]);
            Console.WriteLine("Last name :" + parts[1]);
        }
        if (parts.Length == 3)
        {
            Console.WriteLine("First name :" + parts[0]);
            Console.WriteLine("Middle name :" + parts[1]);
            Console.WriteLine("Last name:" + parts[2]);
        }

        
    }
}
