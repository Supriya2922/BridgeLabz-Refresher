namespace Program6_RandomNumbers;
class Program
{
    static void Main(string[] args)
    {
        Random randomNum= new Random();
        int avg = 0,sum=0;
        Console.WriteLine("Randomly generated five numbers are:");
        for(int i=0;i<5;i++) {
            int num = randomNum.Next(10, 51);
            Console.Write(num+" ");
            sum += num;
        }
        avg = sum / 5;
        Console.WriteLine("\nAverage of the 5 numbers :" + avg);
    }
}