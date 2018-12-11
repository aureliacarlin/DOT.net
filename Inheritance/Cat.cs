using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Animal
    {
        public bool hisses { get; set; }
        public int NumOfLegs { get; set; }
        public bool HasWhiskers { get; set; }


        public override void StateType()
        {
            Console.WriteLine("I am a cat.");
        }

        public override void GetMad()
        {
            Console.WriteLine("Hisssss!");
        }
    }
}
