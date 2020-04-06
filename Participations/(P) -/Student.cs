using System;
using System.Collections.Generic;
using System.Text;

namespace _P___
{//Robert Young
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> CourseNames { get; set; }
        public List<string> CourseGrades { get; set; }

        public Student()
        {
            FirstName = " ";
            LastName = " ";
            CourseNames.Add(" ");
            CourseGrades.Add(" ");           
        }
        public Student(string first, string second)
        {
            FirstName = first;
            LastName = second;
        }
        public double CalculateGPA(double TotalCreditHoursRecieved, double TotalCreditHoursAttempted)
        {          
            return (TotalCreditHoursRecieved / TotalCreditHoursAttempted);
        }
    }
}
