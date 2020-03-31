using System;

namespace _P__Classes
{
    class Program
    {//Robert Young
        static void Main(string[] args)
        {
            int padNum;
            char pad;
            ConsoleColor backColor, foreColor;
            string DisplayText;

            TextBox TB1 = new TextBox();
            padNum = 40;
            pad = '-';
            backColor = ConsoleColor.Red;
            foreColor = ConsoleColor.White;
            DisplayText = "Happy Birthday World!";

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
            
            Console.WriteLine(DisplayText.PadLeft(padNum, pad));

            TextBox TB2 = new TextBox();
            padNum = 30;
            pad = '-';
            backColor = ConsoleColor.Green;
            foreColor = ConsoleColor.Blue;
            DisplayText = "Happy Midnight World!";

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;
            
            Console.WriteLine(DisplayText.PadLeft(padNum, pad));

            Console.ReadKey();
        }

    }
}
