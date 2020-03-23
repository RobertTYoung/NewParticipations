using System;

namespace Participations
{
    class Program
    {//Robert Young
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a type of animal. (cow, snake, dog, cat, etc) >>");
            string AnimalType = Console.ReadLine().ToLower();

            string noise = Speak(AnimalType);

            Console.WriteLine(noise);

            Console.ReadKey();
        }
        static string Speak(string AnimalType)
        {
            if (AnimalType == "cow")
            {
                return "Moo";
            }
            else if (AnimalType == "cat")
            {
                return "Meow";
            }
            else if (AnimalType == "dog")
            {
                return "Woof";
            }
            else if (AnimalType == "snake")
            {
                return "Hiss";
            }
            else
            {
                Console.WriteLine("Sorry, that animal's information is not avaliable.");
            }
            return "Sorry, that animal's information is not avaliable.";
        }
    }
}
