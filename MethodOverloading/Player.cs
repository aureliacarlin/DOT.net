﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Player
    {
        public void Attack()
        {
            Console.WriteLine("The player attacked for 5 points");
        }

        public void Attack(int attackPoints)
        {
            Console.WriteLine("The player attacked for {0} points and has the sword", attackPoints);
        }

        public void Attack(int attackPoints, string weaponName)
        {
            Console.WriteLine("The player attacked for {0} points and has a {1}", attackPoints, weaponName);
        }
    }
}
