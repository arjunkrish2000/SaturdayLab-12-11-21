using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_Lab
{
    internal class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
        //private int _discount { get; set; }

        //public void Disc() {
        //    
        //}
        private  int _discount;

        public int Discount
        {
            get { return _discount; }
            set {
                if (Price > 150)
                {
                    _discount = 10;
                    Console.WriteLine($"You got Discount of {_discount}%");
                    Console.WriteLine($"Orginal Price = {Price}");
                    Price = Price - (Price / 10);
                    Console.WriteLine($"Price to pay = {Price}");
                }
            }
        }

        }
}
