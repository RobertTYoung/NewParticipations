using System;

namespace _P___
{
    class Program
    {//Robert Young
        static void Main(string[] args)
        {
            string first, second, CourseName;
            double TotalCreditHoursAttempted, TotalCreditHoursRecieved;
            first = "Mike";
            second = "Mikelsan";
            CourseName = "MIS3013";
            TotalCreditHoursAttempted = 15;
            TotalCreditHoursRecieved = 12;

            //Student S1 = new Student();
            //S1.FirstName = "Robert";
            // S1.LastName = "Young";

            Student S2 = new Student (first, second);
            first = "Mike";
            second = "Mikelsan";
            CourseName = "MIS3013";
            TotalCreditHoursAttempted = 15;
            TotalCreditHoursRecieved = 12;

            Console.WriteLine($"{first}" + " " + $"{second} earned {TotalCreditHoursRecieved} out of {TotalCreditHoursAttempted} in {CourseName} and recived a GPA of {S2.CalculateGPA()}.");

            Console.ReadKey();
        }
    }
}
