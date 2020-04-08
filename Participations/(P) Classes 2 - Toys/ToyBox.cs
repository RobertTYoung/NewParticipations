using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes_2___Toys
{
    class ToyBox
    {
        public List<string> Toys { get; set; }
        public string Name { get; }

        public void ToyBox(string Name)
        {
            Toys.Add(Name);

            Toys.ForEach(Console.WriteLine);
            /*foreach (string Name in Toys)
            {
                Console.WriteLine(Name);
            } */          
            //return $"The list of Toys include {Toys}."; 
        }
    }
}
