using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
namespace OOPs
{
    public class Food
    {
        public List<details> rice { get; set; } 
        public List<details> wheats { get; set; }
        public List<details> pulses { get; set; }
    }
    public class details
    {
        public int price_per_kg { get; set; }
        public String name { get; set; }
        public int weight { get; set; }
        public int totalprice { get; set; }
       
    }
    public class Inventory
    {
        public static void inventory()
        {
            String file = @"D:\\BridgeRefresher\\BridgeLabz-Refresher\\OOPs\\inventory.json";
            String json = File.ReadAllText(file);
           dynamic res = Newtonsoft.Json.JsonConvert.DeserializeObject<Food>(json);
            int costrice = 0;
            int costwheat = 0;
            int costpulse = 0;
            Food obj = new Food();
            foreach (var o in res.rice)
            {
                costrice = o.price_per_kg * o.weight;
                List<details> lis = new List<details>();

                lis.Add(new details
                {
                    price_per_kg = o.price_per_kg,
                    name=o.name,
                    weight=o.weight,
                    totalprice= costrice

                }) ;
                obj.rice= lis ;
                foreach (var j in lis)
                {
                    Console.WriteLine(j.name);
                }
            }
           
          foreach(var o in res.wheats)
            {
                costrice = o.price_per_kg * o.weight;
                List<details> lis = new List<details>();

                lis.Add(new details
                {
                    price_per_kg = o.price_per_kg,
                    name = o.name,
                    weight = o.weight,
                    totalprice = costrice

                });
                obj.wheats = lis;
            }
          foreach(var o in res.pulses)
            {
                costrice = o.price_per_kg * o.weight;
                List<details> lis = new List<details>();

                lis.Add(new details
                {
                    price_per_kg = o.price_per_kg,
                    name = o.name,
                    weight = o.weight,
                    totalprice = costrice

                });
                obj.pulses= lis;
            }
            string jsonstring = JsonConvert.SerializeObject(obj);
            String newfile = @"D:\\BridgeRefresher\\BridgeLabz-Refresher\\OOPs\\NewInventory.json";
            System.IO.File.WriteAllText(newfile, jsonstring);

        }
    }
}
