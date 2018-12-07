using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._01_Types_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine(5 + 2);
            Console.WriteLine(10 - 6);
            Console.WriteLine(2 * 3);
            Console.WriteLine(10 / 2);

            Console.WriteLine(10 % 2);
            Console.WriteLine(10 % 9);
            Console.WriteLine(16 % 3);
            Console.WriteLine(19 % 5);

            decimal bill = 10.00m;
            decimal percent = 1.10m;
            decimal totalBill = bill * percent;
            Console.WriteLine(totalBill);

            Console.ReadLine();
        }
    }
}
