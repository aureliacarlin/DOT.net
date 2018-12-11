using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while(number <= 100)
            {
                Console.WriteLine(number);
                number = number + 5;
            }

            int numbers = 100;
            for (int i = 0; i <= numbers; i++)
                Console.WriteLine(i);

            string[] ArrayList = new string[3];
            ArrayList[0] = "Paul";
            ArrayList[1] = "Kenn";
            ArrayList[2] = "Jenn";

            foreach (string name in ArrayList)
                Console.WriteLine(name);

            int numer = 1000;
            for (int k = 0; k <= numer; k++)
                Console.WriteLine(k);

            int numero = 100;
            for (int j = 0; j <= numero; j += 5)
                Console.WriteLine(j);

            int numbero = 100;
            for(int s = 1; s <= numbero; s++)
                if(s % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (s % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if( s % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(s);
                }

            Console.ReadLine();
        }
    }
}
