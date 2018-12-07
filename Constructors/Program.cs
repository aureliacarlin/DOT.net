using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student carrStudent = new Student();
            Student caliStudent = new Student("Aurelia", "Carlin");
            Student myGrade = new Student("Aurelia", "Carlin", 12);
            Student myAge = new Student("Aurelia", "Carlin", 12, 19);
        }
    }
}
