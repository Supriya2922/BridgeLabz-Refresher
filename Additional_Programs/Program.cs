namespace Additional_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Enter select an option");
                Console.WriteLine("1.Swap nibbles");
                Console.WriteLine("2.Customize Message Demonstration using String Function and RegEx");
                Console.WriteLine("3.Insertion sort algorithm using generics");
                Console.WriteLine("4.Exit");

                Console.WriteLine("Enter your choice:");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        SwapNibbles.swap();
                        break;
                    case 2:
                        regex.regexFunc();
                        break;
                    case 3:
                        Sorting.sort(); break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}