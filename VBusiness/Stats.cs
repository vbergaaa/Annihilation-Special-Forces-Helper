using System;
using VEntityFramework.Model;

namespace VBusiness
{
	public class Stats : VStats
	{
		public Stats(VLoadout loadout) : base(loadout)
		{
		}

		protected override void SetDefaultValuesCore()
		{
			Attack = 100;
			AttackSpeed = 100;
			CriticalChance = 0;
			CriticalDamage = 100;
			Health = 100;
			HealthArmor = 100;
			Shields = 100;
			ShieldsArmor = 100;
			Acceleration = 100;
		}

		public override double Damage
		{
			get
			{
				var remainingChance = 1.0;

				var blackCritChance = HasBlackCrits ? CriticalChance / 300 : 0;
				blackCritChance = blackCritChance > 1 ? 1 : blackCritChance;

				remainingChance -= blackCritChance;

				var redCritChance = HasRedCrits ? CriticalChance / 200 : 0;
				redCritChance = remainingChance * redCritChance;
				redCritChance = redCritChance > remainingChance ? remainingChance : redCritChance;

				remainingChance -= redCritChance;

				var regAtkChance = CriticalChance > 100 ? 0 : 1 - CriticalChance / 100;

				remainingChance -= regAtkChance;

				var yellowCritChance = remainingChance;

#if DEBUG
				if (Math.Round(blackCritChance + redCritChance + yellowCritChance + regAtkChance, 10) != 1)
				{
					throw new Exception("your crit calculations must be wrong");
				}
#endif

				var coreDamage = (regAtkChance * Attack) + (yellowCritChance * (Attack + CriticalDamage)) + (redCritChance * (Attack + 2 * CriticalDamage)) + (blackCritChance * (Attack + 3.5 * CriticalDamage));
				var damage = coreDamage * (1 + DamageIncrease / 100);
				return Math.Round(damage * AttackSpeed / 100, 2);
			}
		}

		public override double Toughness
		{
			get
			{
				/// This calculation assumes a unit with 100 base health, 50 base shields, and 5 base armor
				/// We then calculate how much damage is required to kill it in 100 attacks
				/// This is then normalised to a score out of 100

				var healthArmor = (HealthArmor) / 20;
				var health = Health;
				var shieldsArmor = (ShieldsArmor) / 20;
				var shields = Shields / 100 * 50;

				/// To get result I solved the following for X,
				/// 
				/// H / (x - Ah) + S / (x - As) = 100
				/// 
				/// where
				/// H = amount of Health
				/// S = amount of Shields
				/// Ah = Health Armor
				/// As = Shield Armor
				/// 100 = amount of hits required to kill our unit

				var a = Math.Pow(100 * (shieldsArmor - healthArmor), 2)
					+ Math.Pow(shields + health, 2)
					+ (shields - health) * shieldsArmor * 200
					+ (health - shields) * healthArmor * 200;
				var b = Math.Sqrt(a) + 100 * shieldsArmor + 100 * healthArmor + shields + health;
				var totalDamageRequiredToKillUnit = b / 2;
				var totalToughness = totalDamageRequiredToKillUnit / (1 - TotalDamageReduction / 100);
				var normalisedToughness = totalToughness / 650 * 100;
				return Math.Round(normalisedToughness, 2);
			}
		}

		public override double Recovery => 0;
	}
}
