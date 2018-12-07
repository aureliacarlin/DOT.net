using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Charlie";
            lastName = "Brown";
            occupation = "Stuntman";

            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            Console.WriteLine("Name: {0}" + "\n" + "Occupation: {1}", fullName, occupation);

            

            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);
            Console.WriteLine(first + " " + second);

            Console.WriteLine("Type a word");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string reversedWord = new string(wordArray);
            Console.WriteLine(reversedWord);

            Console.ReadLine();
        }
    }
}
