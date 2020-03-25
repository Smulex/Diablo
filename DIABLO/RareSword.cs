using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO
{
    class RareSword : Sword
    {
        private int magicProperties;

        public int MagicProperties
        {
            get { return magicProperties; }
            set { magicProperties = value; }
        }
        public RareSword(string name, int minDamage, int maxDamage, double attacksPerSecond, int magicProperties) : base(name, minDamage, maxDamage, attacksPerSecond)
        {
            this.magicProperties = magicProperties;
        }
        public override string ToString()
        {
            return base.ToString() + " +" + magicProperties + " Ramdom Magic Properties";
        }
    }
}
