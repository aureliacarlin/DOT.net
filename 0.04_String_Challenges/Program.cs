using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_String_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "What am I doing??????";
            string answer = "Ummm, leanring C#. Obviously.";
            Console.WriteLine(test + " " + answer);

            string day = "Tuesday";
            string time = "3 o' clock";

            Console.WriteLine("Today is {0} and it is {1}.", day, time );

            string snow = "I can't believe ";
            string snowing = "it's snowing so much!";

            Console.WriteLine($"Wow, {snow}{snowing}");

            string dateString = DateTime.Today.ToShortDateString();
            Console.WriteLine(dateString);

            Console.WriteLine($"Today is {dateString}. I've been out of school for two weeks, and am ready to begin my career as a developer!");

            string upperName = "ARICARLIN";
            string lowerName = "aricarlin";

            




            Console.ReadLine();
        }
    }
}
