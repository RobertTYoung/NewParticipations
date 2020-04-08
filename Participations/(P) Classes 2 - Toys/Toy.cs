using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes_2___Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price  { get; set; }
        private string Aisle { get; set; }


        public Toy ()
        {
            Manufacturer = " ";
            Name = " ";
            Price = 0;
            Aisle = " ";
        }
        public void GetAisle(string Manufacturer)
        {
            return (Manufacturer - (Manufacturer.Length - 1));
        }
    }
}
