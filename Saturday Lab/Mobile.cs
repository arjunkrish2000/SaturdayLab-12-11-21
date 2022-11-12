using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_Lab
{
    internal class Mobile
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }

        public void readData(string name, string model, int price)
        {
            Console.WriteLine();
            Name = name; Model = model; Price = price; 
            Company = "TopMob Pvt";
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Name : {Price}");
            Console.WriteLine($"Name : {Company}");
        }
        public void readData(string name, string model, int price, string companyName)
        {
            Console.WriteLine();
            Name=name; Model = model; Price = price;Company = companyName;
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Name : {Price}");
            Console.WriteLine($"Name : {Company}");
        }
    }
}
