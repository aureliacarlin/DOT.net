using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = new string[4];

            food[0] = "Macaroni";
            food[1] = "pasta";
            food[2] = "Pizza";
            food[3] = "Popcorn";

            string[] foods = { "Rice", "Bread", "Ice cream" };
            Console.WriteLine(foods);
            Console.WriteLine(food[0]);
            Console.ReadLine();
        }
    }
}
