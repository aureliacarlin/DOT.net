using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bear : Animal
    {
        public bool hibernate { get; set; }
        public bool steasPicnicBaskets { get; set; }
        public int numberOfSalmonPerDay { get; set; }
        public string temperatureOfPorridge { get; set; }

        public override void StateType()
        {
            Console.WriteLine("I am a bear.");
        }

        public void EatHiker()
        {
            Console.WriteLine("Man that hiker tasted great.");
        }

        public override void GetMad()
        {
            Console.WriteLine("I am a BIG BAD BEAR!!");
        }
    }
}
