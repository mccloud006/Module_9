using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public Stack<double> grades;
        public static int StudentCount = 0;

        public Student(string firstName, string lastName, DateTime dob)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = dob;
            this.grades = new Stack<double>();
        }              
    }
}
