namespace IOFileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Select an option :");
                Console.WriteLine("1.Read and write text file ");
                Console.WriteLine("2.Read and write csv file ");
                Console.WriteLine("3.Read and write json file ");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice:");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Write operation");
                        TextFile.write();
                        Console.WriteLine();
                        Console.WriteLine("Read operation");
                        TextFile.read();
                        break;
                    case 2:
                        Console.WriteLine("Write operation");
                        CSVFile.write();
                        Console.WriteLine();
                        Console.WriteLine("Read operation");
                        CSVFile.read();
                        break;
                    case 3:
                        Console.WriteLine("Write operation");
                        JSONFile.write();
                        Console.WriteLine();
                        Console.WriteLine("Read operation");
                        JSONFile.read();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}