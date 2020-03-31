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
            string text, Newtext;

            TextBox TB1 = new TextBox();
            padNum = 2;
            pad = '-';
            backColor = ConsoleColor.Red;
            foreColor = ConsoleColor.White;
            text = "Happy Birthday World!";

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;

            Newtext = text.PadLeft(padNum);
            Console.WriteLine(Newtext.PadLeft(padNum));

            TextBox TB2 = new TextBox();
            padNum = 8;
            pad = '-';
            backColor = ConsoleColor.Green;
            foreColor = ConsoleColor.Blue;
            text = "Happy Midnight World!";

            Console.BackgroundColor = backColor;
            Console.ForegroundColor = foreColor;

            Newtext = text.PadRight(padNum, pad);
            Console.WriteLine(Newtext);

            Console.ReadKey();
        }

    }
}
