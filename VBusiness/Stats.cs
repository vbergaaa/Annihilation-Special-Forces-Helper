using VEntityFramework.Model;

namespace VBusiness
{
	public class Stats : VStats
	{
		public Stats() : base()
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
			DamageReduction = 0;
		}
	}
}
