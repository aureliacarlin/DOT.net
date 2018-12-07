using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Ternary_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            string response = ((number == 7) ? "The number is 7." : "The number is not 7.");
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
