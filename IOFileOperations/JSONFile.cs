using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace IOFileOperations
{
    internal class JSONFile
    {
        public static void write()
        {
            Console.WriteLine("Enter the details of the employee \nFirst Name \nLast Name\nAddress\nPhone number\nEmail");
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            String adress = Console.ReadLine();
            long phno = Convert.ToInt64(Console.ReadLine());
            String mail = Console.ReadLine();
            string file = @"D:\BridgeRefresher\BridgeLabz-Refresher\IOFileOperations\employee.json";
            
            var list = new List<Employee>();
            list.Add(new Employee() { fName = firstName, lName = lastName, address = adress, phoneNumber = phno, email = mail });
            string json=JsonConvert.SerializeObject(list.ToArray());
            System.IO.File.WriteAllText(file,json);
            

        }
        public static void read() {
            string file = @"D:\BridgeRefresher\BridgeLabz-Refresher\IOFileOperations\employee.json";
            dynamic res = Newtonsoft.Json.JsonConvert.DeserializeObject(File.ReadAllText(file));
            foreach (var obj in res)
            {
                Console.WriteLine($"Employee name \nFirst Name: {obj.fName}\n Last Name:{obj.lName}\nAdress:{obj.address}\nPhone number:{obj.phoneNumber}\nEmail:{obj.email}\n\n");
            }
        }
    }
}
