using System;

namespace _P__Classes_2___Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            string Manufacturer, Name, Aisle;
            double Price;

            /*Manufacturer = "Nike";
            Name = "Robert";
            Price = 22.99;*/

            Toy T1 = new Toy();
            T1.Manufacturer = "Nike";
            T1.Name = "Robert";            
            T1.Price = 22.99;

            Console.WriteLine($"{T1.Manufacturer} makes a toy called {T1.Name} on Aisle {T1.GetAisle()} and sells it for {T1.Price}.");

            Console.ReadKey();
            
        }
    }
}
