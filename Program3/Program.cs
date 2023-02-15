// See https://aka.ms/new-console-template for more information
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your favourite place which you want to visit:");
        string place = Console.ReadLine();
        Console.WriteLine(place.ToUpper());
        Console.WriteLine(place.ToLower());
    }
}