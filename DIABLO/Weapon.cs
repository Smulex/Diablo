using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIABLO
{
    public abstract class Weapon
    {
		private string name;
		private double minDamage;
		private double maxDamage;
		private double attacksPerSecond;
		private double damagePerSecond;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public double MinDamage
		{
			get { return minDamage; }
			set { minDamage = value; }
		}
		public double MaxDamage
		{
			get { return maxDamage; }
			set { maxDamage = value; }
		}
		public double AttacksPerSecond
		{
			get { return attacksPerSecond; }
			set { attacksPerSecond = value; }
		}
		public double DamagePerSecond
		{
			get { return damagePerSecond; }
			set { damagePerSecond = value; }
		}

		public Weapon(string name, int minDamage, int maxDamage, double attacksPerSecond)
		{
			this.name = name;
			this.minDamage = minDamage;
			this.maxDamage = maxDamage;
			this.attacksPerSecond = attacksPerSecond;
			this.damagePerSecond = (this.minDamage + this.maxDamage) / 2 * attacksPerSecond;
		}

		public override string ToString()
		{
			return "Name: " + name + " Damage per second: " + damagePerSecond + " Damage: " + minDamage + "-" + maxDamage + " Attacks per second: " + attacksPerSecond;
		}
	}
}
