using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_Lab
{
    internal class Clothe1
    {
        public string Stock { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        private string Sale { get; set; }
        public string SaleCheck() 
        {
            if (Stock.Equals("old"))
            {
                Sale = "Discount";
                Price = Price - (Price / 10);
            }
            else 
            {
                Sale = "Normal";
            }
            return Sale;
        }

    }
}
