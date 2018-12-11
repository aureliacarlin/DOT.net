using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Days value = Days.Saturday;
            if (value == Days.Saturday || value == Days.Sunday)
            {
                Console.WriteLine("It's the greakin weekend baby!");
            }
             else if (value == Days.Friday)
            {
                Console.WriteLine("Friday is basically the weekend.");
            }
            else
            {
                Console.WriteLine("Have fun at work.");
            }
            Console.ReadLine();
        }
    }
}
