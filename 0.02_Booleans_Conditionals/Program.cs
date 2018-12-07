using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Booleans_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 100 / 2;

            if (value == 50)
            {
                Console.WriteLine(true);
            }

            Console.WriteLine("Enter a number");
            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is 1");
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine("Your number is 2");
            }
            else if (UserNumber == 3 )
            {
                Console.WriteLine("Your nmber is 3");
            }
            else
            {
                Console.WriteLine("Wrong number");
            }

            Console.ReadLine();
        }

    }
}
