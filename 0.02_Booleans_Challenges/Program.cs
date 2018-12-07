using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Booleans_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1;
            if (value < 10)
            {
                Console.WriteLine("Less than 10");
            }
            else if (value >= 10)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("What is the password?");
            string password = "LetMeIn1234!";
            if (Console.ReadLine() == password)
            {
                Console.WriteLine("That is correct! You may enter.");
            }
            else if (Console.ReadLine() != password)
            {
                Console.WriteLine("I'm sorry that is incorrect.");
            }

            Console.WriteLine("How do you feel, from 1-5?");
            int feelingNumber = Convert.ToInt32(Console.ReadLine());
            if (feelingNumber == 5)
            {
                Console.WriteLine("I'm so glad to hear that!");
            }
            else if (feelingNumber < 5 && feelingNumber > 2)
            {
                Console.WriteLine("Hope your day get's better.");
            }
            else if (feelingNumber < 3)
            {
                Console.WriteLine("Dang, I'm sorry to hear thata!");
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 5");
            }
            Console.ReadLine();
        }
    }
}
