namespace Functional_Programs
{

    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1.2D Array I/O Operations");
                Console.WriteLine("2.Sum of three Integer adds to ZERO");
                Console.WriteLine("3.Euclidean distance from the point (x, y) to the origin (0, 0).");
                Console.WriteLine("4.Calculate Wind Chill");
                Console.WriteLine("Enter your choice:");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice) {
                    case 1:
                        for(; ; )
                        {
                            Console.WriteLine("Choose the type of 2D array to read and print:");
                            Console.WriteLine("1.Int");
                            Console.WriteLine("2.Boolean");
                            Console.WriteLine("3.Double");
                            Console.WriteLine("4.Exit");
                            Console.WriteLine("Enter your choice:");
                            int ch=Convert.ToInt32(Console.ReadLine());
                            if (ch == 1)
                            {
                              
                                int[,] arr = IOLibrary.readInt2DArray();
                                Console.WriteLine("The array is:");
                                IOLibrary.printInt2DArray(arr);
                            }
                            else if (ch == 2)
                            {
                                bool[,] arr = IOLibrary.readBoolean2DArray();
                                Console.WriteLine("The array is:");
                                IOLibrary.printBoolean2DArray(arr);
                            }
                            else if (ch == 3)
                            {
                                double[,] arr = IOLibrary.readDouble2DArray();
                                Console.WriteLine("The array is:");
                                IOLibrary.printDouble2DArray(arr);
                            }
                            else if (ch == 4)
                                break;
                        }
                        break;
                    case 2:
                        TargetSumZero.targetSumZero();
                        break;
                        
                }

            }
           
        }
    }
}