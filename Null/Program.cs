using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b;
            if (a.HasValue)
                b = a.Value;
            else
                b = 0;
            Console.WriteLine("Value of b is {0}", b);

            int? c = null;
            int d = c ?? 0;
            Console.WriteLine("Value of d is {0}", d);

            Console.ReadLine();
        }
    }
}
