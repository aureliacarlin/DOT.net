using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._01_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5673.73;
            int i = 4;

            double ii = i;

            Console.WriteLine(i);

            int k = 1000;
            float f = k;

            Console.WriteLine(f);

            int r = 75;
            bool b = true;
            Console.WriteLine(r.ToString());
            Console.WriteLine(b.ToString());

            string text = "500";
            int num = int.Parse(text);
            Console.WriteLine(num);

            Console.WriteLine("How are you today on a scale of 1-10?");
            int feelingNumber = Convert.ToInt32(Console.ReadLine());

            if (feelingNumber >= 8 && feelingNumber <= 10)
            {
                Console.WriteLine("Great!");
            }
            else if (feelingNumber == 5)
            {
                Console.WriteLine("eh");
            }

            else if (feelingNumber <= 4 && feelingNumber >=1)
            {
                Console.WriteLine("Sorry");
            }
            else
            {
                Console.WriteLine("Enter a number between 1 and 10");
            }

            int myNum = 500;
            string myString = myNum.ToString();
            Console.WriteLine(myString);

            Console.ReadLine();

        }
    }
}
