﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO
{
    public class Sword : Weapon
    {
        public Sword(string name, int minDamage, int maxDamage, double attacksPerSecond) : base(name, minDamage, maxDamage, attacksPerSecond)
        {

        }
    }
}
