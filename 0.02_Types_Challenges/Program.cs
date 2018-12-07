using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int notNumber;
            int isNumber = 85;
            Console.WriteLine(isNumber);

            string notString;
            string isString = "This is a string!";
            Console.WriteLine(isString);

            bool notBool;
            bool isBool = true;
            Console.WriteLine(isBool);

            float notFloat;
            float isFloat = 2.22f;
            Console.WriteLine(isFloat);

            double notDouble;
            double isDouble = 44.85d;
            Console.WriteLine(isDouble);

            decimal notDecimal;
            decimal isDecimal = 567.9999m;
            Console.WriteLine(isDecimal);
            

            char A = 'A';
            string line = "single sentance fragment";
            Console.WriteLine(A + " " + line);

            int birthYear = Int32.Parse("1999");
            Console.WriteLine("I was born in {0}", birthYear);
            

            Console.ReadLine();
        }
    }
}
