using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Student
    {
        public Student()
        {

        }
        
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }


        public Student(string firstName, string lastName, int grade, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }

    }
}
