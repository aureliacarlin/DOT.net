using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int Multiply(int numONe, int numTwo)
            {
                
                return numONe * numTwo;
            }

            string FullName(string firstName, string lastName)
            {
                return firstName + " " + lastName;
            }

            Console.WriteLine("What is your name?");
            string first = Console.ReadLine();
            string last = Console.ReadLine();

            string userName(string oneName, string twoName)
            {
                return oneName + " " + twoName;
            }


            
            Console.WriteLine(FullName("Nancy", "St. Stacey"));
            Console.WriteLine(Multiply(5, 2));
            Console.WriteLine(userName(first, last));
            Console.ReadLine();
        }
    }
}
