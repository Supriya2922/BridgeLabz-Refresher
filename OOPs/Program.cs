namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Inventory Management");
            Console.WriteLine("2.Stock Management");
            Console.WriteLine("Enter a choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Inventory.inventory();
                    break;
                case 2:
                    Console.WriteLine("Enter the number of stocks");
                    int n=Convert.ToInt32(Console.ReadLine());
                    Stock[] stocks= new Stock[n];
                    double total_value = 0;
                    for(int i=0; i < n; i++)
                    {
                        stocks[i] = new Stock();
                        Console.WriteLine("Enter the name of stock");
                        stocks[i].StockName = Console.ReadLine();
                        Console.WriteLine("Enter the number of shares");
                        stocks[i].ShareNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the share price");
                        stocks[i].SharePrice = Convert.ToDouble(Console.ReadLine());
                        total_value += stocks[i].totVal();
                       
                    }
                    Console.WriteLine("------STOCK REPORT------");
                    for(int i = 0; i < n; i++)
                    {
                        Console.WriteLine("STOCK " + (i + 1));

                        String rep = stocks[i].report();
                        Console.WriteLine(rep);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Total stock value :"+ total_value);
                    break;


            }
           
        }
    }
}