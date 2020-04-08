using System;

namespace _P__Classes_2___Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Manufacturer, Name, Aisle;
            //double Price;

            /*Manufacturer = "Nike";
            Name = "Robert";
            Price = 22.99;*/

            Toy T1 = new Toy();
            T1.Manufacturer = "Nike";
            T1.Name = "Truck";            
            T1.Price = 22.99;

            Console.WriteLine($"{T1.Manufacturer} makes a toy called {T1.Name} on Aisle {T1.GetAisle(T1.Manufacturer)} and sells it for {(T1.Price).ToString("C2")}.");

            Toy T2 = new Toy();
            T2.Manufacturer = "Samsung";
            T2.Name = "Robot";
            T2.Price = 62.99;

            Console.WriteLine($"{T2.Manufacturer} makes a toy called {T2.Name} on Aisle {T2.GetAisle(T2.Manufacturer)} and sells it for {(T2.Price).ToString("C2")}.");
            
            Console.ReadKey();
            
        }
    }
}
