using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     public class PolarBear : Bear
    {
        public int YearsOfLife { get; set; }
        public string FurColor { get; set; }

        public override void GetMad()
        {
            Console.WriteLine("I am cold and mad!");
        }
    }
}
