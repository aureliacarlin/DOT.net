using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "smalll";
            chrisDonut.IsSpecial = false;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;

            Console.WriteLine(nickDonut.Filling);
            Console.ReadLine();
        }
    }
}
