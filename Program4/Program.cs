namespace Program4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        String num = Console.ReadLine();
        Console.WriteLine($"10 * {num}= {Convert.ToDecimal(num) * 10}");
    }
}