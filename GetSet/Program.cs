using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevenFiftyEmployee paul = new ElevenFiftyEmployee();
            paul.Id = 10;
            paul.Name = "Paul";
            paul.CommonWorkQuote = "Somebody's got a case of the Mondays.";
            paul.CompanyName = "Eleven Fifty";

            Console.WriteLine("{0} {1} {2}", paul.Id, paul.Name, paul.CompanyName);
            Console.ReadLine();
        }
    }
}
