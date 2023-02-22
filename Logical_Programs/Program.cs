namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1.Gambler Program");
                Console.WriteLine("2.Coupon numbers");
                Console.WriteLine("3.Simulate Stopwatch Program");
                Console.WriteLine("4.Tic-Tac-Toe Game");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your choice:");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Gambler.gamblerfunc();
                        break;
                    case 2:
                        CouponNumber.coupon();
                        break;
                    case 3:
                        Console.WriteLine("Select 0 to start time");
                        int op1=Convert.ToInt32(Console.ReadLine());
                        if (op1 == 0)
                        {
                            StopWatch.start();
                        }
                        Console.WriteLine("Select 1 to stop time");
                        int op2 = Convert.ToInt32(Console.ReadLine());
                        if (op2 == 1)
                        {
                            StopWatch.stop();
                        }
                        StopWatch.timespan();
                        break;
                        case 4:
                        TicTacToe.ticTacToe();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}