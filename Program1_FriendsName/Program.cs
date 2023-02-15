// See https://aka.ms/new-console-template for more 
using System;

namespace Program1_FriendsName
{
    internal class Program
    {
        public void display(String str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name of my five friends:");
            Program obj = new Program();
            obj.display("Supritha");
            obj.display("Keerthi");
            obj.display("Kavya");
            obj.display("Deepa");
            obj.display("Usha");
        }
    }
}