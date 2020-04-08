using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes_2___Toys
{
    class Toy
    {
        private string GA;

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
        public string GetAisle()
        {
            Manufacturer = manufactuer
        }
        public string GetAisle(string Manufacturer)
        {
            int ManLength = Manufacturer.Length;           
            GA = Manufacturer.Remove(ManLength - 1);
            return GA;
        }
    }
}
