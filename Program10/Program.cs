// See https://aka.ms/new-console-template for more informatio
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The numbers divisible by 7 and not a multiple of 5 between 2000 and 3200 are:");
        for(int i = 2000; i <= 3200; i++)
        {
            if(i%7== 0 && i % 5 != 0)
            {
                Console.Write(i + ",");
            }
        }
    }
}