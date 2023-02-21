using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace IOFileOperations
{
    internal class CSVFile
    {
        public static void write()
        {

            Employee obj = new Employee();
            Console.WriteLine("Enter the details of the employee \nFirst Name \nLast Name\nAddress\nPhone number\nEmail");
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            String adress = Console.ReadLine();
            long phno = Convert.ToInt64(Console.ReadLine());
            String mail = Console.ReadLine();
            //string file = @"D:\BridgeRefresher\BridgeLabz-Refresher\IOFileOperations\employee.csv";
            var writer = new StreamWriter("D:\\BridgeRefresher\\BridgeLabz-Refresher\\IOFileOperations\\employee.csv");
            var list=new List<Employee>();
            list.Add(new Employee() { fName = firstName, lName = lastName, address = adress, phoneNumber = phno, email = mail });
            var csvwriter=new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvwriter.WriteRecords(list);
            csvwriter.Dispose();
            writer.Dispose();
        }
        public static void read()
        {
            var reader = new StreamReader("D:\\BridgeRefresher\\BridgeLabz-Refresher\\IOFileOperations\\employee.csv");
            var csvreader = new CsvReader(reader, CultureInfo.InvariantCulture);
            var csv=csvreader.GetRecords<Employee>();
            foreach(var obj in csv)
            {
                Console.WriteLine($"Employee name \nFirst Name: {obj.fName}\n Last Name:{obj.lName}\nAdress:{obj.address}\nPhone number:{obj.phoneNumber}\nEmail:{obj.email}\n\n");
            }
            reader.Dispose();
            csvreader.Dispose();
           
        }
    }
}
