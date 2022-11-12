using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_Lab
{
    internal class Furniture
    {
        public string Type { get; set; }
        public string Wood{ get; set; }
        public int price { get; set; }

        public Furniture()
        {
            Type = "A1";
            Wood = "Teak";
            price = 13000;
        }

        public Furniture(string wood)
        {
            Type = "A1";
            Wood = wood;
            price = 13000;
        }
    }
}
