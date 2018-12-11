using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Animal
    {
        string _latinName;

        public string LatinName
        {
            get
            {
                return _latinName;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can't be empty");
                }
                else
                {
                    _latinName = value.Trim();
                }
            }
        }
        public string Habitat { get; set; }
        
        public int NumberOfLegs { get; set; }
        public int Weight { get; set; }
        public int AverageNumOffspring { get; set; }

        public bool HasFur { get; set; }
        public bool HasWings { get; set; }
        public bool CanFly { get; set; }

        public virtual void StateType()
        {
            Console.WriteLine("I am an animal");
        }

        public virtual void GetMad()
        {
            Console.WriteLine("Roar!!");
        }

        
    }
}
