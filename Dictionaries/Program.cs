using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            IDictionary<string, string> goldentGirls = new Dictionary<string, string>();
            goldentGirls.Add("Rose", "Sweet");
            goldentGirls.Add("Dorothy", "Sharp");
            goldentGirls.Add("Blanche", "Southern");
            goldentGirls.Add("Sophia", "Sassy");

            foreach (KeyValuePair<string, string> pair in goldentGirls)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            IDictionary<string, string> TV = new Dictionary<string, string>();
            TV.Add("Gilmore Girls", "Lorelai");
            TV.Add("Agents of Shield", "Fitz Simmons");
            TV.Add("Once Upon a Time", "Emma");
            TV.Add("New Girl", "Homeless guy");
            TV.Add("24", "Tony Almeda");

            IDictionary<string, string[]> test = new Dictionary<string, string[]>();
            test.Add("numb", new string[] { "One", "two", "three" } );
            test.Add("fruit", new string[] { "apple", "cherry", "banana" });

            foreach (KeyValuePair<string, string[]> pair in test)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }


            Console.ReadLine();
        }
    }
}
