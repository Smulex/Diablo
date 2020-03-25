using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO
{
    public class WeaponFactory
    {
        public Weapon Create(int type)
        {
            switch (type)
            {
                case 0:
                    return new Axe("Aidan's Revenge", 6, 10, 1.30);
                case 1:
                    return new MagicAxe("War Axe", 14, 16, 1, 3);
                case 2:
                    return new Sword("Flamberge", 12, 17, 1.10);
                case 3:
                    return new RareSword("Claymore", 63, 93, 1.10, 4);
                case 4:
                    return new MagicAxe("The Butcher's Cleaver", 2, 3, 1.30, 3);
                case 5:
                    return new RareAxe("Battle Axe", 12, 21, 1.30, 4);
                case 6:
                    return new MagicSword("King's Sworrd of Haste", 2, 4, 1.40, 3);
                case 7:
                    return new RareSword("Great Sword", 81, 120, 1.10, 4);
                case 8:
                    return new RareAxe("Dread Axe", 1048, 1274, 1.10, 6);
                case 9:
                    return new Sword("Oni Blade", 593, 885, 1.10);
                default:
                    return new Sword("Gay Sword", 1, 1, 2.5);
            }
        }
        public Weapon CreateCommonAxe(string name, int minDamage, int maxDamage, double attacksPerSecond)
        {
            return new Axe(name, minDamage, maxDamage, attacksPerSecond);
        }
        public Weapon CreateMagicAxe(string name, int minDamage, int maxDamage, double attacksPerSecond, int magicProperties)
        {
            return new MagicAxe(name, minDamage, maxDamage, attacksPerSecond, magicProperties);

        }
        public Weapon CreateRareAxe(string name, int minDamage, int maxDamage, double attacksPerSecond, int magicProperties)
        {
            return new RareAxe(name, minDamage, maxDamage, attacksPerSecond, magicProperties);
        }
        public Weapon CreateCommonSword(string name, int minDamage, int maxDamage, double attacksPerSecond)
        {
            return new Sword(name, minDamage, maxDamage, attacksPerSecond);

        }
        public Weapon CreateMagicSword(string name, int minDamage, int maxDamage, double attacksPerSecond, int magicProperties)
        {
            return new MagicSword(name, minDamage, maxDamage, attacksPerSecond, magicProperties);

        }
        public Weapon CreateRareSword(string name, int minDamage, int maxDamage, double attacksPerSecond, int magicProperties)
        {
            return new RareAxe(name, minDamage, maxDamage, attacksPerSecond, magicProperties);
        }
    }
}
