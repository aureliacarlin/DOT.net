using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal georgeTheAnimalSteel = new Animal();
            georgeTheAnimalSteel.GetMad();

            Bear barryTheBear = new Bear();
            barryTheBear.LatinName = "Ursidae";
            barryTheBear.GetMad();
            barryTheBear.EatHiker();
            barryTheBear.numberOfSalmonPerDay = 10;
            barryTheBear.StateType();

            Cat benvolioTheBoo = new Cat();

            Console.ReadLine();
        }
    }
}
