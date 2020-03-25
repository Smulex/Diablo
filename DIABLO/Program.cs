using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t0 - Aidan's Revenge (Common Axe)");
            Console.WriteLine("\t1 - War Axe (Magic Axe)");
            Console.WriteLine("\t2 - Flamberge (Common Sword)");
            Console.WriteLine("\t3 - Claymore (Rare Sword)");
            Console.WriteLine("\t4 - The Butcher's Cleaver (Magic Axe)");
            Console.WriteLine("\t5 - Battle Axe (Rare Axe)");
            Console.WriteLine("\t6 - King's Sworrd of Haste (Magic Sword)");
            Console.WriteLine("\t7 - Great Sword (Rare Sword)");
            Console.WriteLine("\t8 - Dread Axe (Rare Axe)");
            Console.WriteLine("\t9 - Oni Blade (Common Sword)");


            Console.Write("Choose your first weapon: ");
            int weapon1 = Int32.Parse(Console.ReadLine());

            Console.Write("Choose your second weapon: ");
            int weapon2 = Int32.Parse(Console.ReadLine());

            Weapon firstWeapon = new WeaponFactory().Create(weapon1);
            Weapon secondWeapon = new WeaponFactory().Create(weapon2);

            Console.WriteLine("First weapon: " + firstWeapon.ToString());
            Console.WriteLine("Second weapon: " + secondWeapon.ToString());

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("\t1 - Create Common Axe");
            Console.WriteLine("\t2 - Create Magic Axe");
            Console.WriteLine("\t3 - Create Rare Axe");
            Console.WriteLine("\t4 - Create Common Sword");
            Console.WriteLine("\t5 - Create Magic Sword");
            Console.WriteLine("\t6 - Create Rare Sword");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    Console.Write("Choose a name: ");
                    string w1Name = Console.ReadLine();
                    Console.Write("Choose min damage: ");
                    int w1MinDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose max damage: ");
                    int w1MaxDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose attacks per second: ");
                    double w1AttacksPerSecond = double.Parse(Console.ReadLine());

                    Weapon w1 = new WeaponFactory().CreateCommonAxe(w1Name, w1MinDamage, w1MaxDamage, w1AttacksPerSecond);

                    Console.WriteLine("\nYou craeted: " + w1.ToString());
                    break;
                case ConsoleKey.D2:
                    Console.Write("Choose a name: ");
                    string w2Name = Console.ReadLine();
                    Console.Write("Choose min damage: ");
                    int w2MinDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose max damage: ");
                    int w2MaxDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose attacks per second: ");
                    double w2AttacksPerSecond = double.Parse(Console.ReadLine());
                    Console.Write("Choose how many magic properties: ");
                    int w2MagicProperties = Int32.Parse(Console.ReadLine());

                    Weapon w2 = new WeaponFactory().CreateMagicAxe(w2Name, w2MinDamage, w2MaxDamage, w2AttacksPerSecond, w2MagicProperties);

                    Console.WriteLine("\nYou craeted: " + w2.ToString());
                    break;
                case ConsoleKey.D3:
                    Console.Write("Choose a name: ");
                    string w3Name = Console.ReadLine();
                    Console.Write("Choose min damage: ");
                    int w3MinDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose max damage: ");
                    int w3MaxDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose attacks per second: ");
                    double w3AttacksPerSecond = double.Parse(Console.ReadLine());
                    Console.Write("Choose how many magic properties: ");
                    int w3MagicProperties = Int32.Parse(Console.ReadLine());

                    Weapon w3 = new WeaponFactory().CreateRareAxe(w3Name, w3MinDamage, w3MaxDamage, w3AttacksPerSecond, w3MagicProperties);

                    Console.WriteLine("\nYou craeted: " + w3.ToString());
                    break;
                case ConsoleKey.D4:
                    Console.Write("Choose a name: ");
                    string w4Name = Console.ReadLine();
                    Console.Write("Choose min damage: ");
                    int w4MinDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose max damage: ");
                    int w4MaxDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose attacks per second: ");
                    double w4AttacksPerSecond = double.Parse(Console.ReadLine());
                    Console.Write("Choose how many magic properties: ");
                    int w4MagicProperties = Int32.Parse(Console.ReadLine());

                    Weapon w4 = new WeaponFactory().CreateCommonSword(w4Name, w4MinDamage, w4MaxDamage, w4AttacksPerSecond);

                    Console.WriteLine("\nYou craeted: " + w4.ToString());
                    break;
                case ConsoleKey.D5:
                    Console.Write("Choose a name: ");
                    string w5Name = Console.ReadLine();
                    Console.Write("Choose min damage: ");
                    int w5MinDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose max damage: ");
                    int w5MaxDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose attacks per second: ");
                    double w5AttacksPerSecond = double.Parse(Console.ReadLine());
                    Console.Write("Choose how many magic properties: ");
                    int w5MagicProperties = Int32.Parse(Console.ReadLine());

                    Weapon w5 = new WeaponFactory().CreateMagicSword(w5Name, w5MinDamage, w5MaxDamage, w5AttacksPerSecond, w5MagicProperties);

                    Console.WriteLine("\nYou craeted: " + w5.ToString());
                    break;
                case ConsoleKey.D6:
                    Console.Write("Choose a name: ");
                    string w6Name = Console.ReadLine();
                    Console.Write("Choose min damage: ");
                    int w6MinDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose max damage: ");
                    int w6MaxDamage = Int32.Parse(Console.ReadLine());
                    Console.Write("Choose attacks per second: ");
                    double w6AttacksPerSecond = double.Parse(Console.ReadLine());
                    Console.Write("Choose how many magic properties: ");
                    int w6MagicProperties = Int32.Parse(Console.ReadLine());

                    Weapon w6 = new WeaponFactory().CreateRareSword(w6Name, w6MinDamage, w6MaxDamage, w6AttacksPerSecond, w6MagicProperties);

                    Console.WriteLine("\nYou craeted: " + w6.ToString());
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
