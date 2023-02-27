
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace IOFileOperations
{
    internal class TextFile
    {
        public static void read()
        {
            string file = @"D:\BridgeRefresher\BridgeLabz-Refresher\IOFileOperations\employee.txt";
        
            Console.WriteLine("Contents of file are:");
            if (File.Exists(file))
            {
                StreamReader Textfile = new StreamReader(file);
                string line;
                while ((line = Textfile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                Textfile.Close();

            }
        }
        public static void write()
        {
            Employee obj= new Employee();
            Console.WriteLine("Enter the details of the employee \nFirst Name \nLast Name\nAddress\nPhone number\nEmail");
            obj.fName=Console.ReadLine();
            obj.lName=Console.ReadLine();
            obj.address=Console.ReadLine();
            obj.phoneNumber=Convert.ToInt64(Console.ReadLine());
            obj.email = Console.ReadLine();
            string file = @"D:\BridgeRefresher\BridgeLabz-Refresher\IOFileOperations\employee.txt";
            string text = $"Employee name \nFirst Name: {obj.fName}\n Last Name:{obj.lName}\nAdress:{obj.address}\nPhone number:{obj.phoneNumber}\nEmail:{obj.email}\n\n";
            File.WriteAllText(file, text);
            
        }
    }
}
