using System;

namespace _P__Classes___Rectangle_And_Circle
{
    class Program
    {//Robert Young
        static void Main(string[] args)
        {
            double L, W, R;
            L = 4;
            W = 13;
            R = 7;

            Rectangle R1 = new Rectangle();
            R1.Length = 10;
            R1.Width = 11;

            Console.WriteLine($"Since the first rectangles Length is {R1.Length} and the Width is {R1.Width} the Area is {R1.CalculateAreaR()}.");
            Console.WriteLine($"Since the first rectangles Length is {R1.Length} and the Width is {R1.Width} the Perimeter is {R1.CalculatePerimeterR()}.");

            Rectangle R2 = new Rectangle(W, L);

            Console.WriteLine($"Since the first rectangles Length is {R2.Length} and the Width is {R2.Width} the Area is {R2.CalculateAreaR()}.");
            Console.WriteLine($"Since the first rectangles Length is {R2.Length} and the Width is {R2.Width} the Perimeter is {R2.CalculatePerimeterR()}.");

            Circle C1 = new Circle();
            C1.Radius = 14;

            Console.WriteLine($"The radius of the the circleis {C1.Radius} so the Area is {C1.CalculateAreaC()}.");
            Console.WriteLine($"The radius of the the circleis {C1.Radius} so the Perimeter is {C1.CalculatePerimeterC()}.");

            Circle C2 = new Circle(R);

            Console.WriteLine($"The radius of the the circleis {C2.Radius} so the Area is {C2.CalculateAreaC()}.");
            Console.WriteLine($"The radius of the the circleis {C2.Radius} so the Perimeter is {C2.CalculatePerimeterC()}.");

            Console.ReadKey();
        }
    }
}
