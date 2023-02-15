namespace Program9_ExecutionTime;
class Program
{
    static void Main(string[] args)
    {
        DateTime start = DateTime.Now;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello World!");
        }
        DateTime end = DateTime.Now;
        TimeSpan time = (end - start);
        Console.WriteLine($"Execution time of the program:{time.TotalMilliseconds}ms");
    }
}